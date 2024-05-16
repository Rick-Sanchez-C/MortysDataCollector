using System.Diagnostics;
using MortysDataCollector.Core.Entities;

namespace MortysDataCollector.Core.Interfaces;

public interface ISystemInfoService
{
    IEnumerable<ProcessInfo> GetRunningProcesses();
}