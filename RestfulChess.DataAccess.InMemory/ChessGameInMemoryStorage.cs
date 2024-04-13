using System.Collections.Concurrent;
using System.Threading;
using RestfulChess.Common.Contracts.Games;
using RestfulChess.DataAccess.Contracts;

namespace RestfulChess.DataAccess.InMemory;
public class ChessGameInMemoryStorage : IChessGameStorage
{
    private static readonly ConcurrentDictionary<long, ChessGame> GameStore =
        new ConcurrentDictionary<long, ChessGame>();

    private static long GameIdentifierCounter = 0L;
    private static SemaphoreSlim _semaphore = new SemaphoreSlim(1);
    public Task<ICollection<long>> GetAvailableGamesAsync()
    {
        return Task.FromResult(GameStore.Keys);
    }

    public Task<ChessGame> GetGameAsync(long gameId)
    {
        if (GameStore.ContainsKey(gameId))
        {
            return Task.FromResult(GameStore[gameId]);
        }

        throw new ArgumentException("Given game identifier does not match existing game IDs.");
    }

    public async Task CreatorGameAsync(ChessGame chessGame)
    {
        if (chessGame == null) throw new ArgumentNullException(nameof(chessGame));

        await _semaphore.WaitAsync();
        try
        {
            GameIdentifierCounter++;
            chessGame.GameIdentifier = GameIdentifierCounter;
        }
        finally
        {
            _semaphore.Release();
        }
        var success = GameStore.TryAdd(chessGame.GameIdentifier, chessGame);
        if (!success)
        {
            throw new InvalidOperationException("Creating new game was not possible!");
        }
    }

    public Task UpdateGameAsync(ChessGame chessGame)
    {
        if (chessGame == null) throw new ArgumentNullException(nameof(chessGame));
        var success = GameStore.TryUpdate(chessGame.GameIdentifier, chessGame, GameStore[chessGame.GameIdentifier]);
        if (!success)
        {
            throw new InvalidOperationException("Updating game was not possible!");
        }

        return Task.CompletedTask;
    }

    public Task DeleteGameAsync(long gameId)
    {
        GameStore.Remove(gameId, out _);
        return Task.CompletedTask;
    }
}
