using System.Windows;
using MagicWpfDemo.Views;
using Prism.Ioc;
using Prism.Modularity;
using PrismWpfDemoModule;

namespace MagicWpfDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<DemoModule>();
        }
    }
}
