using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core依赖注入_DI_讲解.Entity
{
    public class Account
    { 
        public Guid id { get; set; }
        public DateTime ModifiedTime { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
    }
}
