using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core依赖注入_DI_讲解.Service
{
    public class Operation : IOperation, IOperationTransient,
      IOperationScoped, IOperationSingleton, IOperationInstance
    {
        public Operation()
        {
            OperationId = Guid.NewGuid();
        }
        public Operation(Guid operationId)
        {
            if (operationId == null)
            {
                OperationId = Guid.NewGuid();
            }
            OperationId = operationId;
        }

        public Guid OperationId { get; }
    }
}
