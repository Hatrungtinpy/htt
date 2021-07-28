using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigSchool0.Startup))]
namespace BigSchool0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
