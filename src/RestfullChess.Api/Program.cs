using RestfulChess.Business.Implementation;

namespace RestfullChess.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

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
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}