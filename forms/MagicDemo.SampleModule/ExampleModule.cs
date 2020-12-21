using System;
using Prism.Ioc;
using Prism.Magician;
using Prism.Modularity;

[assembly: NameFormatProvider(NameFormatProviderStyle.TypeName)]
namespace MagicDemo.SampleModule
{
    [AutoRegisterViews]
    public partial class ExampleModule : IModule
    {
        public void OnInitialized(IContainerProvider container)
        {
            // This will be auto-generated in an upcoming release...
        }

        // RegisterTypes is auto-generated with registrations for any Views and Services
    }
}
