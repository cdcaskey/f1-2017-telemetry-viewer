using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
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

            if (args.Length > 0)
                int.TryParse(args[0], out listenPort);

            var consoleLocked = false;

            _udpListener = new UdpListener(listenPort);
            _udpListener.DataReceived += ((sender, data) => {
                var packet = new UdpPacket(data);
                if (!consoleLocked)
                {
                    consoleLocked = true;
                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine($"Lap: {packet.Lap + 1} of {packet.TotalLaps}\r\n" +
                        $"Position: {packet.CarPosition} of {packet.NumberOfCars}\r\n" +
                        $"Last Lap Time: {packet.LastLapTime}\r\n" +
                        $"Best Lap Time: {packet.CarData[packet.PlayerCarIndex].BestLapTime}\r\n" +
                        $"\r\n" +
                        $"1st - {(ModernDrivers)packet.CarData.First(x => x.Position == 1).DriverId}\r\n" +
                        $"2nd - {(ModernDrivers)packet.CarData.First(x => x.Position == 2).DriverId}\r\n" +
                        $"3rd - {(ModernDrivers)packet.CarData.First(x => x.Position == 3).DriverId}");
                    consoleLocked = false;
                }
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
