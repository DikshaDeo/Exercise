using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrainingExercises.Startup))]
namespace TrainingExercises
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
