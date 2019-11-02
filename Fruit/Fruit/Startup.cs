using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fruit.Startup))]
namespace Fruit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
