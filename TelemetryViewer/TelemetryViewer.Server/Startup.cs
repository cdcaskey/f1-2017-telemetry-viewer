using Owin;
using Microsoft.Owin.Cors;

namespace TelemetryViewer.Server
{
    class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR();
        }
    }
}
