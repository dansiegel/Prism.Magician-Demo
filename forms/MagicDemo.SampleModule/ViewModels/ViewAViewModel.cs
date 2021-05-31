using MagicDemo.SampleModule.Services;
using Prism.Magician;

namespace MagicDemo.SampleModule.ViewModels
{
    [AutoInitialize]
    public partial class ViewAViewModel : ViewModelBase
    {
        public ViewAViewModel(BaseServices baseServices)
            : base(baseServices)
        {
            Title = "View A";
        }

        [Bindable]
        public string Message { get; set; }
    }
}
