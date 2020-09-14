using System;
using Prism.Ioc;
using Prism.Magician;
using Prism.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: NameFormatProvider(NameFormatProviderStyle.CamelCaseNoPageSuffix)]
namespace MagicDemo
{
    [AutoRegisterViews]
    public partial class App
    {
        public App()
        {

        }

        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync("home/navigation/tabbed?createTab=bindable&createTab=reactive")
                .OnNavigationError(OnNavigationError);
        }

        private void OnNavigationError(Exception ex)
        {
            System.Diagnostics.Debugger.Break();
        }
    }
}
