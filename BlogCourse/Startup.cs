using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogCourse.Startup))]
namespace BlogCourse
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
