using RestfulChess.Common.Contracts.Games;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestfulChess.Business.Contracts;
public interface IChessGameProvider
{
    Task<bool> IsGameAvailableAsync(long gameIdentifier);

    Task<ChessGame> GetGameAsync(long gameIdentifier);
}
