namespace MortysDataCollector.Core.Entities;

public class ProcessInfo
{
    public int ProcessId { get; set; }
    public string ProcessName { get; set; }
    public long MemoryUsage { get; set; }
    public TimeSpan CpuTime { get; set; }
    
}