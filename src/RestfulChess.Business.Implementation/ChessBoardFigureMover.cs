using RestfulChess.Common.Contracts.Exceptions;
using RestfulChess.Common.Contracts.Figures;
using RestfulChess.Common.Contracts.Games;
using System;
using System.Data;
using System.Linq;

namespace RestfulChess.Business.Implementation
{
    public class ChessBoardFigureMover
    {
        /// <summary>
        /// Set a figure on the given field. If field is already set, check if beating other figure is allowed.
        /// </summary>
        public void MoveFigureToField(ChessBoard board,
            BoardPosition newPosition,
            ChessFigure figure)
        {
            if (board == null) throw new ArgumentNullException(nameof(board));
            if (newPosition == null) throw new ArgumentNullException(nameof(newPosition));
            if (figure == null) throw new ArgumentNullException(nameof(figure));
            if (!IsValidBoardPosition(newPosition)) throw new MovementException($"The new position {newPosition.ToString()} is not on the board!");
            // delete old position if not the same
            if (figure.Position != null
                && figure.Position != newPosition)
            {
                ClearPositionFromFigures(board, figure.Position);
            }
            figure.Position = newPosition;
            var field = board.Fields.Single(x => x.Position == newPosition);
            if (field.HasFigureOnField)
            {
                var oldFigure = field.FigureOnField;
                if (oldFigure.Color == figure.Color)
                {
                    throw new MovementException($"{figure} tries to move onto a field with {field.FigureOnField}");
                }
                else
                {
                    oldFigure.Position = null; // remove old figure from chess board
                }
            }
            field.FigureOnField = figure;

        }

        private void DropFigureFromBoard(ChessFigure figure)
        {
            figure.Position = new BoardPosition(Common.Contracts.Enumerations.EColumnPosition.None, Common.Contracts.Enumerations.ERowPosition.None);
        }

        private void ClearPositionFromFigures(ChessBoard board, BoardPosition position)
        {
            var positionInBoard = board.Fields.SingleOrDefault(x => x.Position == position);
            if (positionInBoard != null)
            {
                positionInBoard.FigureOnField = null;
            }
        }

        private bool IsValidBoardPosition(BoardPosition position)
        {
            if (position == null) return false;
            if (position.Column == Common.Contracts.Enumerations.EColumnPosition.None) return false;
            if (position.Row == Common.Contracts.Enumerations.ERowPosition.None) return false;
            var columnValue = (int)position.Column;
            var rowValue = (int)position.Row;
            if (columnValue >= 1
                && columnValue <= 8
                && rowValue >= 1
                && rowValue <= 8)
            {
                return true;
            }
            return false;
        }
    }
}
