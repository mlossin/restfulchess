using RestfulChess.Common.Contracts.Enumerations;

namespace RestfulChess.Common.Contracts.Figures
{
    /// <summary>
    /// Chess figure for special movement of an L shape
    /// </summary>
    public class KnightDto : ChessFigureDto
    {
        private int _baseValue = 4;

        public override FigureType FigureType => FigureType.Knight;
    }
}
