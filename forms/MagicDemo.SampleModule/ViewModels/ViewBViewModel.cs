using MagicDemo.SampleModule.Services;
using Prism.Magician;

namespace MagicDemo.SampleModule.ViewModels
{
    public partial class ViewBViewModel : ViewModelBase
    {
        public ViewBViewModel(BaseServices baseServices)
            : base(baseServices)
        {
        }

        [Bindable]
        public string Message { get; set; }
    }
}
