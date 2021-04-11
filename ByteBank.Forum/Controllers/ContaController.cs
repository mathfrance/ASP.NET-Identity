using ByteBank.Forum.ViewsModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Forum.Controllers
{
    public class ContaController : Controller
    {
        public ActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(ContaRegistrarViewModel modelo)
        {
            return View();
        }
    }
}
