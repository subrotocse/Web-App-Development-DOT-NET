using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MigrationAdvanced.Startup))]
namespace MigrationAdvanced
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
