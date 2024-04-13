using RestfulChess.Common.Contracts.Enumerations;

namespace RestfulChess.Common.Contracts.Figures
{
    /// <summary>
    /// Chess figure for straight movement of multiple fields
    /// </summary>
    public class Rook : ChessFigure
    {
        private int _baseValue = 8;
        public override FigureType GetFigureType()
        {
            return FigureType.Rook;
        }
    }
}
