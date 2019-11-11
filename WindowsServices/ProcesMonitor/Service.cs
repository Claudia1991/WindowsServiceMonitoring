using ProcessMonitor.Helper;
using System.ServiceProcess;
using System.Diagnostics;
using System.Timers;
using ProcesMonitor.Busisness;
using ProcesMonitor.Model;

namespace ProcesMonitor
{
    public partial class Service : ServiceBase
    {
        #region Properties
        private int eventId = 1;
        #endregion
        #region Constructor
        public Service()
        {
            InitializeComponent();
            if (!System.Diagnostics.EventLog.SourceExists("MySource"))
            {
                System.Diagnostics.EventLog.CreateEventSource(
                    "MySource", "MyNewLog");
            }
            eventLog.Source = "MySource";
            eventLog.Log = "MyNewLog";
            Timer _timer = new Timer();
            _timer.Interval = 1800000;
            _timer.Elapsed += new ElapsedEventHandler(this.OnTimer);
            _timer.Start();
        }
        #endregion
        #region Protected Override Methods
        protected override void OnStart(string[] args)
        {
            LogManager.LogStatusService("On Start");
            eventLog.WriteEntry("OnStart");
        }

        protected override void OnStop()
        {
            LogManager.LogStatusService("On Stop");
            eventLog.WriteEntry("On Stop");
        }
        #endregion
        #region Public Methods
        public void OnTimer(object sender, ElapsedEventArgs args)
        {
            eventLog.WriteEntry("Monitoring the processes.", System.Diagnostics.EventLogEntryType.Information, eventId++);
            ProcessModel _process = ProcessBusiness.GetProcesByConsume(Process.GetProcesses());
            LogManager.LogProcess(_process);
        }
        #endregion
    }
}
