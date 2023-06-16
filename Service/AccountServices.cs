using ASP.NET_Core依赖注入_DI_讲解.Context;
using ASP.NET_Core依赖注入_DI_讲解.Entity;
using ASP.NET_Core依赖注入_DI_讲解.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core依赖注入_DI_讲解.Service
{
    public class AccountServices : IAccountServices
    {
        AccessManagementContext _context;
        public AccountServices(AccessManagementContext context)
        {
            _context = context;//在构造函数中注入
        }

        public async Task<List<Account>> GetList()
        {
            try
            {
                var query = _context.Account.ToListAsync();
                return await query;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
