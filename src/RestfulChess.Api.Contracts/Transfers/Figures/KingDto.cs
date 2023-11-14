using RestfulChess.Common.Contracts.Enumerations;

namespace RestfulChess.Common.Contracts.Figures
{
    /// <summary>
    /// Chess figure for straight and diagonal movement of one field
    /// </summary>
    public class KingDto : ChessFigureDto
    {
        private int _baseValue = int.MaxValue;

        public override FigureType FigureType => FigureType.King;
    }
}
