using ASP.NET_Core依赖注入_DI_讲解.Entity;
using ASP.NET_Core依赖注入_DI_讲解.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core依赖注入_DI_讲解.Service
{
    public interface IAccountServices
    {
        Task<List<Account>> GetList();
    }
}
