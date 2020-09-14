using Prism.Magician;
using ReactiveUI;

namespace MagicDemo.Services
{
    public partial class AppSettings : ReactiveObject, IAppSettings
    {
        [Reactive]
        public string UserName { get; set; }
    }
}
