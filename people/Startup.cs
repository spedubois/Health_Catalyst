using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(people.Startup))]
namespace people
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
