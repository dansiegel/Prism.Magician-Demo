using MagicWpfDemo.Core.Mvvm;
using MagicWpfDemo.Core.Services;
using Prism.Mvvm;

namespace MagicWpfDemo.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel(BaseServices baseServices)
            : base(baseServices)
        {
            Title = "Prism Application";

            RegionManager.RequestNavigate("ContentRegion", "ViewA");
        }
    }
}
