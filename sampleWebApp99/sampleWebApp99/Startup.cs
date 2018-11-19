using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sampleWebApp99.Startup))]
namespace sampleWebApp99
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
