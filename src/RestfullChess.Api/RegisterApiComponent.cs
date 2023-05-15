
using RestfulChess.Common.Contracts.Registrations;

namespace RestfullChess.Api
{
    /// <summary>
    /// Registrierrungskomponente für die API
    /// </summary>
    public class RegisterApiComponent : IRegistrationComponent
    {
        public void Register(IServiceCollection serviceCollection)
        {
            serviceCollection.AddAutoMapper(typeof(RegisterApiComponent).Assembly); //register this assembly
            serviceCollection.AddControllers();
            serviceCollection.AddCors();
            serviceCollection.AddEndpointsApiExplorer();
            serviceCollection.AddSwaggerGen();
        }
    }
}
