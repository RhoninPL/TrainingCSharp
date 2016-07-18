using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyPage.Startup))]
namespace MyPage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
