using RestfulChess.Business.Implementation;
using RestfulChess.Business.Implementation.Registrations;
using RestfulChess.DataAccess.InMemory;
using RestfullChess.Api.Middlewares;

namespace RestfullChess.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //Logging
            builder.Logging.ClearProviders();
            builder.Logging.AddConsole();

            // Add services to the container.
            new WebApiComponentRegistration().Register(builder.Services);
            builder.Services.RegisterDataAccessInMemory();
            builder.Services.RegisterBusiness();

            // Build middleware
            var app = builder.Build();
            ApplyMiddleware(app);

            // Run
            app.Run();
        }

        private static void ApplyMiddleware(WebApplication app)
        {
            // Configure the HTTP request pipeline.
            app.UseExceptionMiddleware();
            //app.UseExceptionHandler();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            else
            {
                app.UseHsts();
            }
            app.UseCors();
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}