using RestfulChess.Common.Contracts.Enumerations;
using RestfulChess.Common.Contracts.Figures;

namespace RestfulChess.Common.Contracts.Games
{
    /// <summary>
    /// Represents a single field on the chess board. May indicate if a game figure stays on that field.
    /// </summary>
    public class BoardField
    {
        public EPlayerColors FieldColor { get; set; }

        public ChessFigure FigureOnField { get; set; }

        public bool HasFigureOnField => FigureOnField != null;

        public BoardPosition Position { get; set; }
    }
}
