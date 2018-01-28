using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DATN_ThiBangLaiXe.Startup))]
namespace DATN_ThiBangLaiXe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
