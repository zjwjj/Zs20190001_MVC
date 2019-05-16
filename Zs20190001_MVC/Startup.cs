using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zs20190001_MVC.Startup))]
namespace Zs20190001_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
