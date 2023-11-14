using RestfulChess.Business.Implementation;
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
            new RegisterApiComponent().Register(builder.Services);
            new BusinessComponentRegistration().Register(builder.Services);
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