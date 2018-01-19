using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OneToManyMvcEFCodeFirst.Startup))]
namespace OneToManyMvcEFCodeFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
