using System;
using System.Collections.Generic;
using System.Text;

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
