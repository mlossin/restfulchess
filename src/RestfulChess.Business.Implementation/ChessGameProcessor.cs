using RestfulChess.Business.Contracts;
using RestfulChess.Common.Contracts.Enumerations;
using RestfulChess.Common.Contracts.Games;
using RestfulChess.DataAccess.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestfulChess.Business.Implementation
{
    internal class ChessGameProcessor : IChessGameProcessor
    {
        private readonly ChessBoardCreator _chessBoardCreator;
        private readonly IChessGameProvider _chessGameProvider;
        private readonly IChessGameStorage _chessGameStorage;
        private SemaphoreSlim semaphore = new SemaphoreSlim(1);
        private ChessGame _currentChessGame = null; //by default no game is set!

        public ChessGameProcessor(ChessBoardCreator chessBoardCreator, 
            IChessGameProvider chessGameProvider, 
            IChessGameStorage chessGameStorage)
        {
            _chessBoardCreator = chessBoardCreator ?? throw new ArgumentNullException(nameof(chessBoardCreator));
            _chessGameProvider = chessGameProvider ?? throw new ArgumentNullException(nameof(chessGameProvider));
            _chessGameStorage = chessGameStorage ?? throw new ArgumentNullException(nameof(chessGameStorage));
        }

        public async Task<ChessBoard> GetBoardAsync()
        {
            CheckGame();
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

        private void CheckGame()
        {
            if (_currentChessGame is null)
            {
                throw new InvalidOperationException("No chess game is currently set to operate with");
            }
        }

        public Task<EPlayerColors> GetCurrentPlayerAsync()
        {
            CheckGame();
            return Task.FromResult(_currentChessGame.CurrentPlayer);
        }

        public async Task<ICollection<BoardPosition>> GetPossiblePositionsAsync(BoardPosition sourcePosition)
        {
            CheckGame();
            await semaphore.WaitAsync();
            throw new NotImplementedException();
        }

        public async Task<long> StartNewGameAsync(string whitePlayerName, string blackPlayerName)
        {
            var chessBoard = _chessBoardCreator.CreateChessBoard();
            var playerBlack = new PlayerInformation()
            {
                Color = EPlayerColors.Black,
                Name = blackPlayerName,
                TimeUsed = 0
            };
            var playerWhite = new PlayerInformation()
            {
                Color = EPlayerColors.White,
                Name = whitePlayerName,
                TimeUsed = 0
            };
            var newGame = new ChessGame()
            {
                ChessBoard = chessBoard,
                PlayerBlack = playerBlack,
                PlayerWhite = playerWhite,
                GameIdentifier = -1,
                CurrentPlayer = EPlayerColors.White //white always starts the game
            };
            await _chessGameStorage.CreatorGameAsync(newGame); //identifier will be created here
            return newGame.GameIdentifier;
        }

        public Task<bool> IsGameRunningAsync()
        {
            CheckGame();
            var whiteKingAvailable = _currentChessGame.ChessBoard.Fields.Any(x =>
                x.FigureOnField.GetFigureType() == FigureType.King && x.FigureOnField.Color == EPlayerColors.White);
            var blackKingAvailable = _currentChessGame.ChessBoard.Fields.Any(x =>
                x.FigureOnField.GetFigureType() == FigureType.King && x.FigureOnField.Color == EPlayerColors.Black);
            return Task.FromResult(whiteKingAvailable && blackKingAvailable);
        }

        public async Task SetGame(long gameIdentfier)
        {
            _currentChessGame = await _chessGameProvider.GetGameAsync(gameIdentfier);

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
