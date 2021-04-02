using MagicWpfDemo.Core.Mvvm;
using MagicWpfDemo.Core.Services;
using Prism.Magician;

namespace PrismWpfDemoModule.ViewModels
{
    public class ViewAViewModel : ViewModelBase
    {
        public ViewAViewModel(BaseServices baseServices)
            : base(baseServices)
        {
            Message = "View A from your Prism Module";
        }

        [Bindable]
        public string Message { get; set; }
    }
}
