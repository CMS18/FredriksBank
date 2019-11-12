using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FredriksBank.Web.Controllers
{
    public class MiickesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}