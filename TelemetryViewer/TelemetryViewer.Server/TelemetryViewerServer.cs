using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace TelemetryViewer.Server
{
    public partial class TelemetryViewerServer : ServiceBase
    {
        public TelemetryViewerServer()
        {
            InitializeComponent();
        }

        internal void OnCommandLineStart(string[] args) => OnStart(args);

        internal void OnCommandLineStop(string[] args) => OnStop();

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }
    }
}
