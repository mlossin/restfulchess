using RestfulChess.Common.Contracts.Enumerations;

namespace RestfulChess.Common.Contracts.Figures
{
    /// <summary>
    /// Chess figure for straight and diagonal movement of multiple fields
    /// </summary>
    public class Queen : ChessFigure
    {
        private int _baseValue = 15;
        public override FigureType GetFigureType()
        {
            return FigureType.Queen;
        }
    }
}
