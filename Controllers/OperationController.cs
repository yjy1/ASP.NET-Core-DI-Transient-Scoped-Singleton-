using ASP.NET_Core依赖注入_DI_讲解.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core依赖注入_DI_讲解.Controllers
{
    public class OperationController : Controller
    {
        public IOperationTransient OperationTransient { get; }
        public IOperationScoped OperationScoped { get; }
        public IOperationSingleton OperationSingleton { get; }
        public IOperationInstance OperationInstance { get; }
        public OperationServices _operationServices;

        public OperationController(IOperationTransient operationTransient,
            IOperationScoped operationScoped,
            IOperationSingleton operationSingleton,
            IOperationInstance operationInstance,
            OperationServices operationServices)
        {
            OperationTransient = operationTransient;
            OperationScoped = operationScoped;
            OperationSingleton = operationSingleton;
            OperationInstance = operationInstance;
            _operationServices = operationServices;
        }
        // GET: Operation
        public ActionResult Index()
        {
            ViewBag.OperationTransient = OperationTransient;
            ViewBag.OperationScoped = OperationScoped;
            ViewBag.OperationSingleton = OperationSingleton;
            ViewBag.OperationInstance = OperationInstance;
            ViewBag._operationServices = _operationServices;
            return View();
        }
    }
}
