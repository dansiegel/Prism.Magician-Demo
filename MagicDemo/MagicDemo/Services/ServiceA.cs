using System;
using Prism.Magician;

namespace MagicDemo.Services
{
    [Register]
    public class ServiceA : IServiceA
    {
        public Guid Id { get; } = Guid.NewGuid();
    }
}
