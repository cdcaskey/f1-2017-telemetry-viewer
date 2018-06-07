using System;
using System.Net;
using System.Net.Sockets;

namespace TelemetryViewer.Server.Helpers
{
    public sealed class UdpListener : IDisposable
    {
        private UdpClient _udpClient;

        public event EventHandler<byte[]> DataReceived;

        public UdpListener(int listenPort)
        {
            _udpClient = new UdpClient(listenPort);
        }

        public void StartListening()
        {
            _udpClient.BeginReceive(new AsyncCallback(result =>
            {
                // Get the Received Data
                var endpoint = new IPEndPoint(IPAddress.Any, 0);
                var data = _udpClient.EndReceive(result, ref endpoint);

                StartListening();

                // Send the data to any interested party
                DataReceived?.Invoke(this, data);
            }), null);
        }

        public void Dispose()
        {
            _udpClient?.Dispose();
            _udpClient = null;
        }
    }
}
