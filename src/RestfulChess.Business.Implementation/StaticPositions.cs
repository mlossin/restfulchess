using RestfulChess.Common.Contracts.Enumerations;
using RestfulChess.Common.Contracts.Games;

namespace RestfulChess.Business.Implementation
{
    public static class PositionFactory
    {
        public static BoardPosition NotOnBoard = new BoardPosition(EColumnPosition.None, ERowPosition.None);
    }
}
