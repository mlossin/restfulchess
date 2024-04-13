using System.Collections.Generic;
using System.Threading.Tasks;
using RestfulChess.Common.Contracts.Games;

namespace RestfulChess.DataAccess.Contracts;
public interface IChessGameStorage
{
    Task<ICollection<long>> GetAvailableGamesAsync();
    /// <summary>
    /// Retrieves a chess game by its identifier
    /// </summary>
    Task<ChessGame> GetGameAsync(long gameId);

    /// <summary>
    /// Create a new chess game with given data. New identifier will be saved in the given object.
    /// Therefore no return value necessary
    /// </summary>
    Task CreatorGameAsync(ChessGame chessGame);

    /// <summary>
    /// Update a chess game with given data.
    /// Therefore no return value necessary
    /// </summary>
    Task UpdateGameAsync(ChessGame chessGame);

    /// <summary>
    /// Delete a chess game by its identifier
    /// </summary>
    Task DeleteGameAsync(long gameId);


}
