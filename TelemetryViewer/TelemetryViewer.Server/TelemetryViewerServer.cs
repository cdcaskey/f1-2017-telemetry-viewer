using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Hosting;
using System;
using System.Linq;
using System.ServiceProcess;
using TelemetryViewer.Server.Helpers;
using TelemetryViewer.Server.Helpers.Enums;
using TelemetryViewer.Server.Models;

namespace TelemetryViewer.Server
{
    public partial class TelemetryViewerServer : ServiceBase
    {
        private UdpListener _udpListener;

        public TelemetryViewerServer()
        {
            InitializeComponent();
        }

        internal void OnCommandLineStart(string[] args) => OnStart(args);

        internal void OnCommandLineStop(string[] args) => OnStop();

        protected override void OnStart(string[] args)
        {
            var listenPort = 20777;
            var hostAddress = "localhost";
            var hostPort = 8080;

            if (args.Length > 0)
                int.TryParse(args[0], out listenPort);
            if (args.Length > 1)
                hostAddress = args[1];
            if (args.Length > 2)
                int.TryParse(args[2], out hostPort);

            WebApp.Start($"http://{hostAddress}:{hostPort}");

            _udpListener = new UdpListener(listenPort);
            _udpListener.DataReceived += ((sender, data) => {
                var packet = new UdpPacket(data);
                var context = GlobalHost.ConnectionManager.GetHubContext<TelemetryHub>();
                context.Clients.All.Send(packet);
            });
            _udpListener.StartListening();

        }

        protected override void OnStop()
        {
            _udpListener.Dispose();
            _udpListener = null;
        }
    }
}
