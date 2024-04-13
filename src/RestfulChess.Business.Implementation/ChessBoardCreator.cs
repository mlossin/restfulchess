using RestfulChess.Common.Contracts.Enumerations;
using RestfulChess.Common.Contracts.Games;
using System.Collections.Generic;
using RestfulChess.Common.Implementations;
using System.Linq;
using RestfulChess.Common.Implementations.Extensions;

namespace RestfulChess.Business.Implementation
{
    /// <summary>
    /// Logic to create a chessboard
    /// </summary>
    public class ChessBoardCreator
    {
        /// <summary>
        /// Creates a chess board with its switching colors.
        /// </summary>
        public ChessBoard CreateChessBoard()
        {
            var currentColor = EPlayerColors.Black;
            var columns = EnumExtensions.GetValues<EColumnPosition>().ToList();
            columns.Remove(EColumnPosition.None);
            var rows = EnumExtensions.GetValues<ERowPosition>().ToList();
            rows.Remove(ERowPosition.None);
            var chessFields = new List<BoardField> ();
            foreach (var column in columns)
            {
                foreach (var row in rows)
                {
                    var field = new BoardField
                    {
                        FieldColor = currentColor,
                        FigureOnField = null,
                        Position = new BoardPosition()
                        {
                            Column = column,
                            Row = row
                        }
                    };
                    chessFields.Add(field);
                    //a1 is black field. Color shall be toggled each field
                    currentColor = PlayerColorToggler.ToggleColor(currentColor);
                }
                // to ensure the column toggle of color it is necessary to toggle color again (e.g. color of h1 == color of a2)
                currentColor = PlayerColorToggler.ToggleColor(currentColor);
            }
            var chessBoard = new ChessBoard()
            {
                Fields = chessFields
            };
            return chessBoard;
        }
    }
}
