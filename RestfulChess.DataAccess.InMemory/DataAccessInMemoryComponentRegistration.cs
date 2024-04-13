using Microsoft.Extensions.DependencyInjection;
using RestfulChess.Common.Contracts.Registrations;
using RestfulChess.DataAccess.Contracts;

namespace RestfulChess.DataAccess.InMemory;
/// <summary>
/// Register all DataAccess contracts by its InMemory implementation with dependencies
/// </summary>
public class DataAccessInMemoryComponentRegistration : IRegistrationComponent
{
    public void Register(IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IChessGameStorage, ChessGameInMemoryStorage>();
    }
}
