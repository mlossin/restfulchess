using Microsoft.Extensions.DependencyInjection;

namespace RestfulChess.DataAccess.InMemory;
public static class DataAccessRegistrationExtensions
{
    public static IServiceCollection RegisterDataAccessInMemory(this IServiceCollection services)
    {
        new DataAccessInMemoryComponentRegistration().Register(services);
        return services;
    }
}
