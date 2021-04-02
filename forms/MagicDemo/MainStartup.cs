using MagicDemo.Services;
using Microsoft.Extensions.DependencyInjection;
using Prism.Ioc;
using Shiny;

namespace MagicDemo
{
    public partial class MainStartup : ShinyStartup
    {
        public override void ConfigureServices(IServiceCollection services, IPlatform platform)
        {
            services.AddSingleton<IAppSettings, AppSettings>();
        }

        private void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // If we have dependencies such at the Prism.Plugin.Logging library
            // that we want to more easily register with the IContainerRegistry
            // extensions... we can simply provide a RegisterTypes method here
            // like we would normally with Prism. This will be automatically called
            // by the Magician before we create the ServiceProvider for Shiny...
            containerRegistry.RegisterConsoleLogger();
        }
    }
}
