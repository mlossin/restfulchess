namespace RestfulChess.Common.Contracts.Games
{
    /// <summary>
    /// Chess game information including the current board, player information and so on
    /// </summary>
    public class ChessGameDto
    {
        public ChessBoardDto ChessBoard { get; set; }
        public PlayerInformationDto PlayerWhite { get; set; }
        public PlayerInformationDto PlayerBlack { get; set; }
    }
}
