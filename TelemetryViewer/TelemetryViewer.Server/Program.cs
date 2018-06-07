using System;
using System.ServiceProcess;

namespace TelemetryViewer.Server
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            if (Environment.UserInteractive)
            {
                new TelemetryViewerServer().OnCommandLineStart(args);

                Console.WriteLine("The server is now running, press enter to exit...");
                Console.ReadLine();
            }
            else
            {
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[]
                {
                    new TelemetryViewerServer()
                };
                ServiceBase.Run(ServicesToRun);
            }
        }
    }
}
