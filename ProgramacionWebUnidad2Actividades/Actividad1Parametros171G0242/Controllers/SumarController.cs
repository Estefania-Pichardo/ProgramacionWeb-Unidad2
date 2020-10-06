using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Actividad1Parametros171G0242.Models;
using Microsoft.AspNetCore.Mvc;

namespace Actividad1Parametros171G0242.Controllers
{
    public class SumarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Resultado(Sumar s)
        {
            return View(s);
        }
    }
}
