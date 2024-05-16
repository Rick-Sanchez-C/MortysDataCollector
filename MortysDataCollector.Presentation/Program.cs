using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MortysDataCollector.Application.Services;
using MortysDataCollector.Core.Interfaces;
using MortysDataCollector.Infrastructure.Services;
using MortysDataCollector.Presentation;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddSingleton<ISystemInfoService, ProcessInfoService>();
        services.AddSingleton<MonitorService>();
        services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();