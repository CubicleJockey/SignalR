using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Tutorial.StartUp))]

namespace Tutorial
{
    public class StartUp
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
