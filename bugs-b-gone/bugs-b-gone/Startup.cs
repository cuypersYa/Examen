using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bugs_b_gone.Startup))]
namespace bugs_b_gone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
