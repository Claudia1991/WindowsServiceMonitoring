using ProcesMonitor.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesMonitor.Busisness
{
    public static class ProcessBusiness
    {
        public static ProcessModel GetProcesByConsume(Process[] _processesModel)
        {
            Process _systemProcess = _processesModel.OrderByDescending(p => p.PeakVirtualMemorySize64).ToList().FirstOrDefault();
            return new ProcessModel() 
            { 
                ProcessName = _systemProcess.ProcessName,
                ProcessId=_systemProcess.Id,
                ProcessConsumeMemory= _systemProcess.PeakVirtualMemorySize64 
            };
        }
    }
}
