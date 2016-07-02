using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetCareManagementSystem.Startup))]
namespace PetCareManagementSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
