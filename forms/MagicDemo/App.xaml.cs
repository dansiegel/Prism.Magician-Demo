using System;
using Prism.Ioc;
using Prism.Magician;
using Prism.Navigation;
using MagicDemo.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.Extensions.DependencyInjection;
using Prism.Modularity;
using MagicDemo.SampleModule;
using Prism.DryIoc;

[assembly: NameFormatProvider(NameFormatProviderStyle.CamelCaseNoPageSuffix)]
namespace MagicDemo
{
    [AutoRegisterViews]
    public partial class App : PrismApplication
    {
        public App()
        {

        }

        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync($"{NavigationKeys.HomePage}/{NavigationKeys.NavigationPage}/{NavigationKeys.ReactivePage}")
                .OnNavigationError(OnNavigationError);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // We don't actually need this method... The generator will supply it for us..
            // If we need to manually register something here we can, and the Magician
            // will generate an AutoRegistration method instead. It will then use IL Weaving
            // to call the AutoRegistration method at the beginning of our RegisterTypes
        }

        private void ConfigureServices(IServiceCollection services)
        {
            // If you're not using Shiny but you would like to use something like the
            // HttpClientFactory, you may want to add a ConfigureServices method with
            // the IServiceCollection to your Application. The Magician will automatically
            // generate some IServiceCollection extensions for you and call this method
            // for you to make it easier for you to use 3rd party extensions.
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ExampleModule>();
        }

        private void OnNavigationError(Exception ex)
        {
            System.Diagnostics.Debugger.Break();
        }
    }
}
