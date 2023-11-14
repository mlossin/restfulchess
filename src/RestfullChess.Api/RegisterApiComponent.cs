
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.OpenApi.Models;
using RestfulChess.Common.Contracts.Registrations;
using RestfullChess.Api.Middlewares;

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
            serviceCollection.AddSwaggerGen(options => {
                options.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                options.IgnoreObsoleteActions();
                options.IgnoreObsoleteProperties();
                options.CustomSchemaIds(type => type.FullName);
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Restful Chess API",
                    Description = "An ASP.NET Core Web API trying to deliver a chess game with the full power of REST",
                    //TermsOfService = new Uri("https://example.com/terms"),
                    Contact = new OpenApiContact()
                    {
                        Name = "Example Contact",
                        Url = new Uri("https://example.com/contact")
                    },
                    License = new OpenApiLicense()
                    {
                        Name = "Example License",
                        Url = new Uri("https://example.com/license")
                    },
                });
            });
        }
    }
}
