using RestfulChess.Common.Contracts.Enumerations;

namespace RestfulChess.Common.Contracts.Figures
{
    /// <summary>
    /// Chess figure forward only movement of a field with some exceptions
    /// </summary>
    public class PawnDto : ChessFigureDto
    {
        private int _baseValue = 1;
        public override FigureType FigureType => FigureType.Pawn;
    }
}
