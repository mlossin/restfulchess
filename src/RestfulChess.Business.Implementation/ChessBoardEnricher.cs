using RestfulChess.Common.Contracts.Enumerations;
using RestfulChess.Common.Contracts.Figures;
using RestfulChess.Common.Contracts.Games;
using System;
using System.Collections.Generic;

namespace RestfulChess.Business.Implementation
{
    /// <summary>
    /// Enrich a chess board with the startup position of each figure for both players
    /// </summary>
    public class ChessBoardEnricher
    {
        private readonly ChessBoardFigureMover chessBoardFigureMover;

        public ChessBoardEnricher(ChessBoardFigureMover chessBoardFigureMover)
        {
            this.chessBoardFigureMover = chessBoardFigureMover ?? throw new ArgumentNullException(nameof(chessBoardFigureMover));
        }

        /// <summary>
        /// Fills an chessboard with a new set of figures for black and white.
        /// </summary>
        public void FillChessBoard(ChessBoard board)
        {
            if (board == null) throw new ArgumentNullException(nameof(board));
            CreateFiguresToColorAndFillBoard(board, EPlayerColors.Black);
            CreateFiguresToColorAndFillBoard(board, EPlayerColors.White);
        }

        /// <summary>
        /// Fills the given board with all figures to the given color.
        /// </summary>
        private void CreateFiguresToColorAndFillBoard(ChessBoard board, EPlayerColors color)
        {
            var figures = new List<ChessFigure>();
            figures.AddRange(ChessFigureFactory.CreatePawns(color));
            figures.AddRange(ChessFigureFactory.CreateRooks(color));
            figures.AddRange(ChessFigureFactory.CreateKnights(color));
            figures.AddRange(ChessFigureFactory.CreateBishops(color));
            figures.Add(ChessFigureFactory.CreateQueen(color));
            figures.Add(ChessFigureFactory.CreateKing(color));

            foreach (var figure in figures)
            {
                chessBoardFigureMover.MoveFigureToField(board, figure.Position ,figure);
            }
        }
    }
}
