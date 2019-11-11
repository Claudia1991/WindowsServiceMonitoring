namespace ProcesMonitor
{
    partial class Installer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            this.ServiceProcessInstaler = new System.ServiceProcess.ServiceProcessInstaller();
            // 
            // ServiceInstaller
            // 
            this.ServiceInstaller.Description = "Servicio de monitoreo de procesos.";
            this.ServiceInstaller.DisplayName = "Servicio de monitoreo de procesos.";
            this.ServiceInstaller.ServiceName = "Service";
            this.ServiceInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ServiceProcessInstaler
            // 
            this.ServiceProcessInstaler.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.ServiceProcessInstaler.Password = null;
            this.ServiceProcessInstaler.Username = null;
            // 
            // Installer
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.ServiceInstaller,
            this.ServiceProcessInstaler});

        }

        #endregion

        private System.ServiceProcess.ServiceInstaller ServiceInstaller;
        private System.ServiceProcess.ServiceProcessInstaller ServiceProcessInstaler;
    }
}