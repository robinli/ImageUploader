using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ImageUploader.Web.Startup))]
namespace ImageUploader.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
