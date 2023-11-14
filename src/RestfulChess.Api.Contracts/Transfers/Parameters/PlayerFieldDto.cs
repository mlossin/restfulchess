using RestfulChess.Common.Contracts.Enumerations;

namespace RestfulChess.Api.Contracts.Transfers.Parameters
{
    /// <summary>
    /// Represents a field coordinate and a player
    /// </summary>
    public class PlayerFieldDto
    {
        public EPlayerColors Player { get; set; }
        public EColumnPosition Column { get; set; }
        public ERowPosition Row { get; set; }
    }
}
