using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core依赖注入_DI_讲解.Service
{
    public interface IOperation
    {
        /// <summary>
        /// 唯一标识
        /// </summary>
        Guid OperationId { get; }
    }

    public interface IOperationTransient : IOperation
    {
    }

    public interface IOperationScoped : IOperation
    {
    }

    public interface IOperationSingleton : IOperation
    {
    }

    public interface IOperationInstance : IOperation
    {
    }
}
