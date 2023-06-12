using RestfulChess.Common.Contracts.Enumerations;
using RestfulChess.Common.Contracts.Games;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace RestfulChess.Common.Contracts.Figures
{
    /// <summary>
    /// Base class for all chess figures
    /// </summary>
    [KnownType(typeof(King))]
    [KnownType(typeof(Queen))]
    [KnownType(typeof(Bishop))]
    [KnownType(typeof(Rook))]
    [KnownType(typeof(Knight))]
    [KnownType(typeof(Pawn))]
    public abstract class ChessFigure
    {
        public EPlayerColors Color { get; set; }

        protected ChessFigure()
        {
            Position = new BoardPosition(EColumnPosition.None, ERowPosition.None);
        }

        /// <summary>
        /// Position of the figure. Null means not on the board!
        /// </summary>
        public BoardPosition Position { get; set; }

        public override string ToString()
        {
            return $"{Color.ToString()} {this.GetType().Name} at {Position?.ToString() ?? "Not on field"}";
        }
    }
}
