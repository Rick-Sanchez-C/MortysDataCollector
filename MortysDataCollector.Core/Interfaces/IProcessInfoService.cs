using System.Diagnostics;
using MortysDataCollector.Core.Entities;

namespace MortysDataCollector.Core.Interfaces;

public interface IProcessInfoService
{
    IEnumerable<ProcessInfo> GetRunningProcesses();
}