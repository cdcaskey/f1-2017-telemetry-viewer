using Microsoft.AspNet.SignalR;
using TelemetryViewer.Server.Models;

namespace TelemetryViewer.Server.Helpers
{
    public class TelemetryHub : Hub
    {
        public void Send(UdpPacket packet) => Clients.All.addMessage(packet);
    }
}