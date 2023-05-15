using RestfulChess.Common.Contracts.Enumerations;
using System.Collections;

namespace RestfulChess.Common.Contracts.Games
{
    /// <summary>
    /// Information to one of the players of the game
    /// </summary>
    public class PlayerInformationDto
    {
        public EPlayerColors Color { get; set; }
        public string Name { get; set; }
        public long TimeUsed { get; set; }
    }
}