using System.Reactive.Disposables;
using MagicDemo.Services;
using Prism.Magician;
using ReactiveUI;
using Shiny;

namespace MagicDemo.ViewModels
{
    [AutoInitialize]
    public partial class ReactiveViewModel : ReactiveViewModelBase
    {
        public ReactiveViewModel(BaseServices baseServices)
            : base(baseServices)
        {
            Title = "Reactive ViewModel";
            _isFooHelper = this.WhenAnyProperty(x => x.FooToggle)
                .ToProperty(this, nameof(IsFoo), false, true)
                .DisposeWith(Disposables);
        }

        [Reactive]
        public string Message { get; set; }

        [Reactive]
        public bool FooToggle { get; set; }

        [ObservableAsProperty]
        public bool IsFoo { get; }
    }
}
