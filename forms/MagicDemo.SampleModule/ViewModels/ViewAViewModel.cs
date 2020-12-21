using System;
using System.Collections.Generic;
using System.Text;
using MagicDemo.SampleModule.Services;
using Prism.Magician;

namespace MagicDemo.SampleModule.ViewModels
{
    public partial class ViewAViewModel : ViewModelBase
    {
        public ViewAViewModel(BaseServices baseServices)
            : base(baseServices)
        {
        }

        [Bindable]
        public string Message { get; set; }
    }
}
