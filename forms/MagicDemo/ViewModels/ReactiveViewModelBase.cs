using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Prism;
using Prism.AppModel;
using Prism.Commands;
using Prism.Common;
using Prism.Events;
using Prism.Magician;
using Prism.Navigation;
using ReactiveUI;
using Shiny;
using Shiny.Net;

namespace MagicDemo.ViewModels
{
    [ViewModelBase]
    public abstract partial class ReactiveViewModelBase : ReactiveObject
    {
    }
}
