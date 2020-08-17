using System;
using MagicDemo.Services;

namespace MagicDemo.ViewModels
{
    public class ServicesViewModel : BindableViewModelBase
    {
        public ServicesViewModel(BaseServices baseServices, IServiceA serviceA, IServiceB serviceB, IServiceC serviceC, IServiceD serviceD)
            : base(baseServices)
        {
            ServiceAId = serviceA.Id;
            ServiceBId = serviceB.Id;
            ServiceCId = serviceC.Id;
            ServiceDId = serviceD.Id;
        }

        public Guid ServiceAId { get; }

        public Guid ServiceBId { get; }

        public Guid ServiceCId { get; }

        public Guid ServiceDId { get; }
    }
}
