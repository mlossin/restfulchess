using RestfulChess.Common.Contracts.Enumerations;

namespace RestfulChess.Common.Contracts
{
    /// <summary>
    /// A position on a chess board by its column and row coordinates
    /// </summary>
    public class BoardPosition
    {
        public EColumnPosition Column { get; set; }
        public ERowPosition Row { get; set; }
    }
}
