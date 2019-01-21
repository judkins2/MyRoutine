using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyRoutine.Startup))]
namespace MyRoutine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
