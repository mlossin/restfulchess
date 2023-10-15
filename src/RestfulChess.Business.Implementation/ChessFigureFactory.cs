using RestfulChess.Common.Contracts.Enumerations;
using RestfulChess.Common.Contracts.Exceptions;
using RestfulChess.Common.Contracts.Figures;
using RestfulChess.Common.Contracts.Games;
using System;
using System.Collections.Generic;

namespace RestfulChess.Business.Implementation
{
    /// <summary>
    /// Enrich a chess board with the startup position of each figure for both players
    /// </summary>
    public static class ChessFigureFactory
    {
        private static readonly ERowPosition whiteBackrow = ERowPosition.One;
        private static readonly ERowPosition whitePawnRow = ERowPosition.Two;
        private static readonly ERowPosition blackBackrow = ERowPosition.Eight;
        private static readonly ERowPosition blackPawnRow= ERowPosition.Seven;
        private static readonly EColumnPosition kingColumn = EColumnPosition.E;
        private static readonly EColumnPosition queenColumn = EColumnPosition.D;

        /// <summary>
        /// Creates a king to the team of the given color.
        /// </summary>
        public static King CreateKing(EPlayerColors color)
        {
            var row = GetBackRowBy(color);
            var king = new King() { Color = color, Position = new BoardPosition(kingColumn,row)};
            return king;
        }

        /// <summary>
        /// Creates a queen to the given color.
        /// </summary>
        public static Queen CreateQueen(EPlayerColors color)
        {
            var row = GetBackRowBy(color);
            var queen = new Queen() { Color = color, Position = new BoardPosition(queenColumn, row) };
            return queen;
        }

        /// <summary>
        /// Creates two bishops for the team of the given color.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static IEnumerable<Bishop> CreateBishops(EPlayerColors color)
        {
            var result = new List<Bishop>();
            var row = GetBackRowBy(color);
            var position1 = new BoardPosition(EColumnPosition.C, row);
            var bishop1 = new Bishop() { Color = color, Position = position1 };
            result.Add(bishop1);
            var position2 = new BoardPosition(EColumnPosition.F, row);
            var bishop2 = new Bishop() { Color = color, Position = position2 };
            result.Add(bishop2);
            return result;
        }

        /// <summary>
        /// Creates two Knight Figures for team based on the color.
        /// </summary>
        public static IEnumerable<Knight> CreateKnights(EPlayerColors color)
        {
            var result = new List<Knight>();
            var row = GetBackRowBy(color);
            var position1 = new BoardPosition(EColumnPosition.B, row);
            var knight1 = new Knight() { Color = color, Position = position1 };
            result.Add(knight1);
            var position2 = new BoardPosition(EColumnPosition.G, row);
            var knight2 = new Knight() { Color = color, Position = position2 };
            result.Add(knight2);
            return result;
        }

        /// <summary>
        /// Creates two Rooks for the team based on the color.
        /// </summary>
        /// <param name="board"></param>
        public static IEnumerable<Rook> CreateRooks(EPlayerColors color)
        {
            var result = new List<Rook>();
            var row = GetBackRowBy(color);
            //black
            var rookPosition1 = new BoardPosition(EColumnPosition.A, row);
            var rook1 = new Rook() {  Color = color, Position = rookPosition1 };
            result.Add(rook1);
            var rookPosition2 = new BoardPosition(EColumnPosition.H, row);
            var rook2 = new Rook() {  Color = color, Position = rookPosition2 };
            result.Add(rook2);
            return result;
        }

        /// <summary>
        /// Create 8 pawns of the given color with their original position.
        /// </summary>
        public static IEnumerable<Pawn> CreatePawns(EPlayerColors color)
        {
            var result = new List<Pawn>();
            switch (color)
            {
                case EPlayerColors.Black:
                    foreach (EColumnPosition column in Enum.GetValues(typeof(EColumnPosition)))
                    {
                        var pawnPosition = new BoardPosition(column, blackPawnRow);
                        var pawn = new Pawn() { Color = color, Position = pawnPosition };
                    }
                    break;
                case EPlayerColors.White:
                    foreach (EColumnPosition column in Enum.GetValues(typeof(EColumnPosition)))
                    {
                        var pawnPosition = new BoardPosition(column, whitePawnRow);
                        var pawn = new Pawn() { Color = color, Position = pawnPosition };
                    }
                    break;
                default: 
                    break;
            }
            return result;
        }

        private static ERowPosition GetBackRowBy(EPlayerColors color)
        {
            switch (color)
            {
                case EPlayerColors.Black:
                    return blackBackrow;
                case EPlayerColors.White:
                    return whiteBackrow;
                default: 
                    throw new ChessException("Cannot get a backrow to a color of neither blac or white");
            }
        }
    }
}
