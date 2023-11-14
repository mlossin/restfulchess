using System.Collections.Generic;

namespace RestfulChess.Common.Contracts.Games
{
    /// <summary>
    /// A chess board with 64 fields
    /// </summary>
    public class ChessBoardDto
    {
        public IList<BoardFieldDto> Fields { get; set; }
    }
}
