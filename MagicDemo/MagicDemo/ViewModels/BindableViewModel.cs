using MagicDemo.Services;
using Prism.Magician;

namespace MagicDemo.ViewModels
{
    public partial class BindableViewModel : BindableViewModelBase
    {
        public BindableViewModel(BaseServices baseServices) : base(baseServices)
        {
        }

        [Bindable]
        public string Message { get; set; }
    }
}
