using System;
using Prism.Magician;

namespace MagicDemo.Services
{
    [RegisterSingleton]
    public class ServiceB : IServiceB
    {
        public Guid Id { get; } = Guid.NewGuid();
    }
}
