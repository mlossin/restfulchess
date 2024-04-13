using RestfulChess.Common.Contracts.Enumerations;
using RestfulChess.Common.Contracts.Games;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestfulChess.Business.Contracts
{
    /// <summary>
    /// Interface for playing the chess game
    /// </summary>
    public interface IChessGameProcessor
    {
        /// <summary>
        /// Sets the Game to use by its identifier.
        /// </summary>
        Task SetGame(long gameIdentfier);

        /// <summary>
        /// Move a figure based on the current active player
        /// </summary>
        Task MoveFigureAsync(BoardPosition sourcePosition, BoardPosition targetPosition);

        /// <summary>
        /// For the given position get the possible movements
        /// </summary>
        Task<ICollection<BoardPosition>> GetPossiblePositionsAsync(BoardPosition sourcePosition);

        /// <summary>
        /// Start a new game of chess. Returns an game identifier.
        /// </summary>
        Task<long> StartNewGameAsync(string whitePlayerName, string blackPlayerName);

        /// <summary>
        /// Check if a game is currently running
        /// </summary>
        Task<bool> IsGameRunningAsync();

        /// <summary>
        /// Returns the player for the next move
        /// </summary>
        Task<EPlayerColors> GetCurrentPlayerAsync();

        /// <summary>
        /// Stops the current game
        /// </summary>
        Task StopGameAsync();

        /// <summary>
        /// Get the chess board of the current game
        /// </summary>
        Task<ChessBoard> GetBoardAsync();
    }
}
