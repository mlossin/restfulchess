using Microsoft.Extensions.DependencyInjection;
using RestfulChess.Business.Contracts;
using RestfulChess.Common.Contracts.Registrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestfulChess.Business.Implementation.Registrations
{
    public class BusinessComponentRegistration : IRegistrationComponent
    {
        public void Register(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IChessGameProcessor, ChessGameProcessor>();
            serviceCollection.AddTransient<ChessBoardCreator>();
            serviceCollection.AddTransient<ChessBoardEnricher>();
            serviceCollection.AddTransient<ChessBoardFigureMover>();
            serviceCollection.AddTransient<IChessGameProvider, ChessGameProvider>();
        }
    }
}
