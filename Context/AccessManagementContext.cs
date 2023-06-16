using ASP.NET_Core依赖注入_DI_讲解.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core依赖注入_DI_讲解.Context
{ 
    public class AccessManagementContext : DbContext
    {
        public AccessManagementContext(DbContextOptions<AccessManagementContext> options) : base(options)
        {

        }
        //Account 命名需要与数据库表名一致
        public DbSet<Account> Account { get; set; }
    }
}
