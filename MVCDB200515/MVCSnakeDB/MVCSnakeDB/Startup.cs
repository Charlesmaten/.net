using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCSnakeDB.Startup))]
namespace MVCSnakeDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
