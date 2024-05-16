using MortysDataCollector.Core.Entities;
using MortysDataCollector.Core.Interfaces;

namespace MortysDataCollector.Application.Services;

public class MonitorService
{
    private readonly ISystemInfoService _systemInfoService;
    public MonitorService(ISystemInfoService systemInfoService)
    {
        _systemInfoService = systemInfoService;
    }
    
    public IEnumerable<ProcessInfo> GetSystemInfo()
    {
        return _systemInfoService.GetRunningProcesses();
    }
}