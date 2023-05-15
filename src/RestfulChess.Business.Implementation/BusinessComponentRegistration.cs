using Microsoft.Extensions.DependencyInjection;
using RestfulChess.Business.Contracts;
using RestfulChess.Common.Contracts.Registrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestfulChess.Business.Implementation
{
    public class BusinessComponentRegistration : IRegistrationComponent
    {
        public void Register(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IChessGame,ChessGame>();
            serviceCollection.AddTransient<ChessBoardCreator>();
        }
    }
}
