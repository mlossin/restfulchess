using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestfulChess.Business.Contracts;
using RestfulChess.Common.Contracts.Games;
using RestfulChess.DataAccess.Contracts;

namespace RestfulChess.Business.Implementation;
internal class ChessGameProvider : IChessGameProvider
{
    private readonly IChessGameStorage _chessGameStorage;

    public ChessGameProvider(IChessGameStorage chessGameStorage)
    {
        _chessGameStorage = chessGameStorage ?? throw new ArgumentNullException(nameof(chessGameStorage));
    }
    public async Task<bool> IsGameAvailableAsync(long gameIdentifier)
    {
        var availableGames = await _chessGameStorage.GetAvailableGamesAsync();
        return availableGames.Any(x => x == gameIdentifier);
    }

    public async Task<ChessGame> GetGameAsync(long gameIdentifier)
    {
        var game = await _chessGameStorage.GetGameAsync(gameIdentifier);
        return game;
    }
}
