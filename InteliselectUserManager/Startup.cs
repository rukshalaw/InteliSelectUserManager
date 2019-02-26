using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InteliselectUserManager.Startup))]
namespace InteliselectUserManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
