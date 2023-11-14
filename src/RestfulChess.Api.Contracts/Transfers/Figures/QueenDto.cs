using RestfulChess.Common.Contracts.Enumerations;

namespace RestfulChess.Common.Contracts.Figures
{
    /// <summary>
    /// Chess figure for straight and diagonal movement of multiple fields
    /// </summary>
    public class QueenDto : ChessFigureDto
    {
        private int _baseValue = 15;

        public override FigureType FigureType => FigureType.Queen;
    }
}
