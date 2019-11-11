using System;
using System.IO;
using System.Configuration;
using ProcesMonitor.Model;

namespace ProcessMonitor.Helper
{
    public static class LogManager
    {
        public static void LogStatusService(string status)
        {
            try
            {
                if (File.Exists(ConfigurationManager.AppSettings["FILELOGPATH"]))
                {
                    File.AppendText(string.Format("Date: {0} - Status Service:{1}", DateTime.Now, status));
                }
                else
                {
                    File.Create(ConfigurationManager.AppSettings["FILELOGPATH"]);
                    File.AppendText(string.Format("Date: {0} - Status Service:{1}", DateTime.Now, status));
                }
            }
            catch (Exception ex)
            {
                LogErrorService(ex.ToString());
            }
        }

        public static void LogErrorService(string error)
        {
            try
            {
                if (File.Exists(ConfigurationManager.AppSettings["FILEERRORPATH"]))
                {
                    File.AppendText(string.Format("Date: {0} - Error Service:{1}", DateTime.Now, error));
                }
                else
                {
                    File.Create(ConfigurationManager.AppSettings["FILEERRORPATH"]);
                    File.AppendText(string.Format("Date: {0} - Error Service:{1}", DateTime.Now, error));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void LogProcess(ProcessModel _processModel)
        {
            try
            {

                if (File.Exists(ConfigurationManager.AppSettings["FILELOGPATH"]))
                {
                    File.AppendText(string.Format("Date: {0} - Process Name:{1} - Process Consume: {2}", DateTime.Now, 
                        _processModel.ProcessName, _processModel.ProcessConsumeMemory));
                }
                else
                {
                    File.Create(ConfigurationManager.AppSettings["FILELOGPATH"]);
                    File.AppendText(string.Format("Date: {0} - Process Name:{1} - Process Consume: {2}", DateTime.Now,
                        _processModel.ProcessName, _processModel.ProcessConsumeMemory));
                }
            }
            catch (Exception ex)
            {
                LogErrorService(ex.ToString());
            }
        }
    }
}
