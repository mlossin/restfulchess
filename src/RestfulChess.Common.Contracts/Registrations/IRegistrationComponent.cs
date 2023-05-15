using Microsoft.Extensions.DependencyInjection;

namespace RestfulChess.Common.Contracts.Registrations
{
    /// <summary>
    /// Interface to register components to a DI container
    /// </summary>
    public interface IRegistrationComponent
    {
        void Register(IServiceCollection serviceCollection);
    }
}
