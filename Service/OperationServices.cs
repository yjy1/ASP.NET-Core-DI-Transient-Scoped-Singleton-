using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core依赖注入_DI_讲解.Service
{
    public class OperationServices
    {
        public IOperationTransient OperationTransient { get; }
        public IOperationScoped OperationScoped { get; }
        public IOperationSingleton OperationSingleton { get; }
        public IOperationInstance OperationInstance { get; }

        public OperationServices(IOperationTransient operationTransient,
            IOperationScoped operationScoped,
            IOperationSingleton operationSingleton,
            IOperationInstance operationInstance)
        {
            OperationTransient = operationTransient;
            OperationScoped = operationScoped;
            OperationSingleton = operationSingleton;
            OperationInstance = operationInstance;
        }
    }
}
