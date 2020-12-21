using MagicDemo.Services;
using Prism.Magician;

namespace MagicDemo.ViewModels
{
    [AutoInitialize]
    public partial class ReactiveViewModel : ReactiveViewModelBase
    {
        public ReactiveViewModel(BaseServices baseServices)
            : base(baseServices)
        {
            
        }

        [Reactive]
        public string Message { get; set; }

        [ObservableAsProperty]
        public bool IsFoo { get; }
    }
}
