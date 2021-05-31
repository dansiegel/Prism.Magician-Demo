using MagicDemo.SampleModule.Services;
using Prism.Magician;

namespace MagicDemo.SampleModule.ViewModels
{
    [AutoInitialize]
    public partial class ViewBViewModel : ViewModelBase
    {
        public ViewBViewModel(BaseServices baseServices)
            : base(baseServices)
        {
            Title = "View B";
        }

        [Bindable]
        public string Message { get; set; }
    }
}
