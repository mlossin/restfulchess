using RestfulChess.Business.Contracts;
using RestfulChess.Common.Contracts.Enumerations;
using RestfulChess.Common.Contracts.Games;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RestfulChess.Business.Implementation
{
    internal class ChessGame : IChessGame
    {
        private readonly ChessBoardCreator chessBoardCreator;
        private SemaphoreSlim semaphore = new SemaphoreSlim(1);

        public ChessGame(ChessBoardCreator chessBoardCreator)
        {
            this.chessBoardCreator = chessBoardCreator ?? throw new ArgumentNullException(nameof(chessBoardCreator));
        }

        public async Task<ChessBoard> GetBoardAsync()
        {
            await semaphore.WaitAsync();
            try
            {

            }
            finally
            {
                semaphore.Release();
            }
            throw new NotImplementedException();
        }

        public async Task<EPlayerColors> GetCurrentPlayerAsync()
        {
            await semaphore.WaitAsync();
            try
            {

            }
            finally
            {
                semaphore.Release();
            }
            throw new NotImplementedException();
        }

        public async Task<ICollection<BoardPosition>> GetPossiblePositionsAsync(BoardPosition sourcePosition)
        {
            await semaphore.WaitAsync();
            try
            {

            }
            finally
            {
                semaphore.Release();
            }
            throw new NotImplementedException();
        }

        public async  Task<bool> IsGameRunningAsync()
        {
            await semaphore.WaitAsync();
            try
            {

            }
            finally
            {
                semaphore.Release();
            }
            throw new NotImplementedException();
        }

        public async Task MoveFigureAsync(BoardPosition sourcePosition, BoardPosition targetPosition)
        {
            await semaphore.WaitAsync();
            try
            {

            }
            finally
            {
                semaphore.Release();
            }
            throw new NotImplementedException();
        }

        public async Task StartNewGameAsync(string whitePlayerName, string blackPlayerName)
        {
            await semaphore.WaitAsync();
            try
            {

            }
            finally
            {
                semaphore.Release();
            }
            throw new NotImplementedException();
        }

        public async Task StopGameAsync()
        {
            await semaphore.WaitAsync();
            try
            {

            }
            finally
            {
                semaphore.Release();
            }
            throw new NotImplementedException();
        }
    }
}
