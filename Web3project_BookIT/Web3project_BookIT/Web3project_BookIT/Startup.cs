using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web3project_BookIT.Startup))]
namespace Web3project_BookIT
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
