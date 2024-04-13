using System;
using System.Collections.Generic;
using System.Text;
using RestfulChess.Common.Contracts.Enumerations;

namespace RestfulChess.Common.Contracts.Games
{
    /// <summary>
    /// Chess game information including the current board, player information and so on
    /// </summary>
    public class ChessGame
    {
        public long GameIdentifier { get; set; }
        public ChessBoard ChessBoard { get; set; }
        public PlayerInformation PlayerWhite { get; set; }
        public PlayerInformation PlayerBlack { get; set; }
        public EPlayerColors CurrentPlayer { get; set; } = EPlayerColors.None;
    }
}
