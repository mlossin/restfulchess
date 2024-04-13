using RestfulChess.Common.Contracts.Enumerations;

namespace RestfulChess.Common.Contracts.Figures
{
    /// <summary>
    /// Chess figure for special movement of an L shape
    /// </summary>
    public class Knight : ChessFigure
    {
        private int _baseValue = 4;
        public override FigureType GetFigureType()
        {
            return FigureType.Knight;
        }
    }
}
