using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(iotminidash.Startup))]
namespace iotminidash
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}