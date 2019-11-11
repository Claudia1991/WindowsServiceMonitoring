using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesMonitor.Model
{
    public class ProcessModel
    {
        public int ProcessId { get; set; }
        public string ProcessName { get; set; }
        public long ProcessConsumeMemory { get; set; }
    }
}
