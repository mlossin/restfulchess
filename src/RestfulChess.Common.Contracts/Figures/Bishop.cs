using RestfulChess.Common.Contracts.Enumerations;

namespace RestfulChess.Common.Contracts.Figures
{
    /// <summary>
    /// Chess figure for diagonal movement of multiple fields
    /// </summary>
    public class Bishop : ChessFigure
    {
        private int _baseValue = 3;
        public override FigureType GetFigureType()
        {
            return FigureType.Bishop;
        }
    }
}
