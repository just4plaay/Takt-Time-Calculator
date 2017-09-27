using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TaktTimeCalculator.Startup))]
namespace TaktTimeCalculator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
