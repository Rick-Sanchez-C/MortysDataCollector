using System.ComponentModel;
using System.Diagnostics;
using MortysDataCollector.Core.Entities;
using MortysDataCollector.Core.Interfaces;

namespace MortysDataCollector.Infrastructure.Services;

public class ProcessInfoService : IProcessInfoService
{
    public IEnumerable<ProcessInfo> GetRunningProcesses()
    {
        var processes = Process.GetProcesses();
        return processes.Select(p => new ProcessInfo
        {
            ProcessName = p.ProcessName,
            CpuTime = SafeGetTotalProcessorTime(p),
            ProcessId = p.Id,
            MemoryUsage = p.PagedMemorySize64
        }).ToList();
    }

    private static TimeSpan SafeGetTotalProcessorTime(Process process)
    {
        try
        {
            return process.TotalProcessorTime;
        }
        catch (Win32Exception ex)
        {
            // Log or handle the exception
            Console.WriteLine($"Access denied for process {process.Id}: {ex.Message}");
            return TimeSpan.Zero;
        }
    }
}