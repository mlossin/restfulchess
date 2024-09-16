using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RestfulChess.Business.Contracts;
using RestfulChess.Business.Implementation;
using RestfulChess.Business.Implementation.Registrations;
using RestfulChess.DataAccess.InMemory;

namespace Chess.Ui.Console;

internal class Program
{

    public static async Task Main(string[] args)
    {

        var services = new ServiceCollection();
        services.RegisterDataAccessInMemory();
        services.RegisterBusiness();
        var serviceProvider = services.BuildServiceProvider();
        var gameProvider = serviceProvider.GetService<IChessGameProvider>();
        var game = await gameProvider.GetGameAsync(1);
    }

    //public static void Main(string[] args)
    //{
    //    var host = CreateHostBuilder(args).Build();
    //    host.Run();
    //}

    //public static IHostBuilder CreateHostBuilder(string[] args) =>
    //    Host.CreateDefaultBuilder(args)
    //        .ConfigureServices((hostContext, services) =>
    //        {
    //            // remove the hosted service
    //            // services.AddHostedService<Worker>();

    //            // register your services here.
    //            new DataAccessInMemoryComponentRegistration().Register(services);
    //            new BusinessComponentRegistration().Register(services);
    //        });
}
