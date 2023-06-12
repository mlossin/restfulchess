using RestfulChess.Common.Contracts.Enumerations;

namespace RestfulChess.Common.Contracts.Games
{
    /// <summary>
    /// A position on a chess board by its column and row coordinates
    /// </summary>
    public record BoardPosition
    {
        public EColumnPosition Column { get; set; }
        public ERowPosition Row { get; set; }

        //Default Constructor for Serialization
        public BoardPosition()
        {
            
        }

        // Parameterized Constructor
        public BoardPosition(EColumnPosition column, ERowPosition row)
        {
            Column = column;
            Row = row;
        }

        public override string ToString()
        {
            return $"{Column}/{Row}";
        }
    }
}
