using RestfulChess.Common.Contracts.Enumerations;
using RestfulChess.Common.Contracts.Exceptions;
using RestfulChess.Common.Contracts.Figures;
using RestfulChess.Common.Contracts.Games;
using System;

namespace RestfulChess.Business.Implementation
{
    /// <summary>
    /// Enrich a chess board with the startup position of each figure for both players
    /// </summary>
    public class ChessBoardEnricher
    {
        private readonly ChessBoardFigureMover chessBoardFigureMover;
        private readonly ERowPosition whiteBackrow = ERowPosition.One;
        private readonly ERowPosition whitePawnRiw = ERowPosition.Two;
        private readonly ERowPosition blackBackrow = ERowPosition.Eight;
        private readonly ERowPosition blackPawnRow= ERowPosition.Seven;
        private readonly EColumnPosition kingColumn = EColumnPosition.E;
        private readonly EColumnPosition queenColumn = EColumnPosition.D;

        public ChessBoardEnricher(ChessBoardFigureMover chessBoardFigureMover)
        {
            this.chessBoardFigureMover = chessBoardFigureMover ?? throw new ArgumentNullException(nameof(chessBoardFigureMover));
        }

        public void FillChessBoard(ChessBoard board)
        {
            if (board == null) throw new ArgumentNullException(nameof(board));
            // white figures
            FillPawns(board);
            FillBackRows(board);
        }

        /// <summary>
        /// Fill the row 1 with white figures and row 8 with black figures
        /// </summary>
        private void FillBackRows(ChessBoard board)
        {
            FillRooks(board);
            FillKnights(board);
            FillBishops(board);
            FillKingsAndQueens(board);
        }

        private void FillKingsAndQueens(ChessBoard board)
        {


            // Black figures

            var blackQueen = new Queen(){ Color = EPlayerColors.Black};
            chessBoardFigureMover.MoveFigureToField(board, new BoardPosition(queenColumn, blackBackrow), blackQueen);
            var blackKing = new King(){Color = EPlayerColors.Black };
            chessBoardFigureMover.MoveFigureToField(board, new BoardPosition(kingColumn, blackBackrow), blackKing);

            // White figures

            var whiteQueen = new Queen() { Color = EPlayerColors.White };
            chessBoardFigureMover.MoveFigureToField(board, new BoardPosition(queenColumn, whiteBackrow), whiteQueen);
            var whiteKing = new King() { Color = EPlayerColors.White };
            chessBoardFigureMover.MoveFigureToField(board, new BoardPosition(kingColumn, whiteBackrow), whiteKing);
        }

        private void FillBishops(ChessBoard board)
        {
            var blackBishop1 = new Bishop() { Color = EPlayerColors.Black };
            var blackBishop2 = new Bishop() { Color = EPlayerColors.Black };
        }

        private void FillKnights(ChessBoard board)
        {
            throw new NotImplementedException();
        }

        private void FillRooks(ChessBoard board)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Fill the board rows 2 with white pawns and 7 with black pawns
        /// </summary>
        private void FillPawns(ChessBoard board)
        {
            var blackRow = ERowPosition.Seven;
            var whiteRow = ERowPosition.Two;
            foreach (EColumnPosition column in Enum.GetValues(typeof(EColumnPosition)))
            {
                // Set black pawn
                var blackPawnPosition = new BoardPosition(column, blackRow);
                var blackPawn = new Pawn() { Color = EPlayerColors.Black, Position = blackPawnPosition };
                chessBoardFigureMover.MoveFigureToField(board, blackPawnPosition, blackPawn);
                //Set white pawn
                var whitePawnPosition = new BoardPosition(column, whiteRow);
                var whitePawn = new Pawn() { Color = EPlayerColors.White, Position = whitePawnPosition };
                chessBoardFigureMover.MoveFigureToField(board, whitePawnPosition, whitePawn);
            }
        }

       
    }
}
