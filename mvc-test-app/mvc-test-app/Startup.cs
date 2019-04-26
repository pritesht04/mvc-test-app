using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc_test_app.Startup))]
namespace mvc_test_app
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
