using Microsoft.Extensions.DependencyInjection;

namespace RestfulChess.Business.Implementation.Registrations;
public static class BusinessRegistrationsExtensions
{
    public static IServiceCollection RegisterBusiness(this IServiceCollection services)
    {
        new BusinessComponentRegistration().Register(services);
        return services;
    }
}
