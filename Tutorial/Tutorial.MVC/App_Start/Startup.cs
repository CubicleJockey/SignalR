using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Tutorial.MVC.App_Start.Startup))]
namespace Tutorial.MVC.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
