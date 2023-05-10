using System;
using System.Collections.Generic;
using System.Text;

namespace RestfulChess.Common.Contracts.Games
{
    /// <summary>
    /// Chess game information including the current board, player information and so on
    /// </summary>
    public class ChessGame
    {
        public ChessBoard ChessBoard { get; set; }
        public PlayerInformation PlayerWhite { get; set; }
        public PlayerInformation PlayerBlack { get; set; }
    }
}
