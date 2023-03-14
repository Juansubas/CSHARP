using Swapi.Core.Interfaces;
using Swapi.Infrastructure.Repositories;
using Swapi.Infrastructure.Services;
using Swapi.Service;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHttpClient<IStartshipService, StartshipService>();

        services.AddTransient<IStartshipRepository, StartshipRepository>();
        services.AddTransient<ILogService, LogService>();
        services.AddTransient<IStartshipService, StartshipService>();

        services.AddHostedService<Worker>();
    })
    .Build();

host.Run();
