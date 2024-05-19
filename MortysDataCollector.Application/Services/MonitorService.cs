using MortysDataCollector.Core.Entities;
using MortysDataCollector.Core.Interfaces;

namespace MortysDataCollector.Application.Services;

public class MonitorService
{
    private readonly IProcessInfoService _processInfoService;
    public MonitorService(IProcessInfoService processInfoService)
    {
        _processInfoService = processInfoService;
    }
    
    public IEnumerable<ProcessInfo> GetSystemInfo()
    {
        return _processInfoService.GetRunningProcesses();
    }
}