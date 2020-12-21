using System;
using Prism.Magician;

namespace MagicDemo.Services
{
    [RegisterManySingleton]
    public class CompositeService : IServiceC, IServiceD
    {
        public Guid Id { get; } = Guid.NewGuid();
    }
}
