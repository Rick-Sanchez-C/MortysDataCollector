using Microsoft.Extensions.Hosting;
using MortysDataCollector.Application.Services;

namespace MortysDataCollector.Presentation;

public class Worker : BackgroundService
{
    private readonly MonitorService _monitorService;
    
    public Worker(MonitorService monitorService)
    {
        _monitorService = monitorService;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            var systemInfo = _monitorService.GetSystemInfo();
            foreach (var info in systemInfo)
            {
                Console.WriteLine($"PID: {info.ProcessId}, Name: {info.ProcessName}, Memory: {info.MemoryUsage}, CPU Time: {info.CpuTime}");
            }
            await Task.Delay(10000, stoppingToken);
        }
    }
}