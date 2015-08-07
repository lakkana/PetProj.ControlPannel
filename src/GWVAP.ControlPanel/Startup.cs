using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GWVAP.ControlPanel.Startup))]
namespace GWVAP.ControlPanel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
