using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviesRent.Startup))]
namespace MoviesRent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
