using RestfulChess.Common.Contracts.Enumerations;

namespace RestfulChess.Common.Contracts.Figures
{
    /// <summary>
    /// Chess figure for straight movement of multiple fields
    /// </summary>
    public class RookDto : ChessFigureDto
    {
        private int _baseValue = 8;
        public override FigureType FigureType => FigureType.Rook;
    }
}
