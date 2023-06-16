using ASP.NET_Core依赖注入_DI_讲解.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core依赖注入_DI_讲解.Controllers
{
    public class AccountController : Controller
    {
        private IAccountServices _accountServices;
        public AccountController(IAccountServices accountServices)
        {
            _accountServices = accountServices;
        }
  
        // GET: Account
        public async Task<ActionResult> Index()
        {
            var vms = await _accountServices.GetList();
            return View(vms);
        }
    }
}
