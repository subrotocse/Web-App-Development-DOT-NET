using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFirstAppEFCodeFirst.Startup))]
namespace MyFirstAppEFCodeFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
