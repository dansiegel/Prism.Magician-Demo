using System;
using MagicUnoDemo.Core.Mvvm;
using Prism.Commands;
using Prism.Mvvm;

namespace MagicUnoDemo.Shared.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        public ShellViewModel()
        {
            Title = "Main Page";
        }
    }
}
