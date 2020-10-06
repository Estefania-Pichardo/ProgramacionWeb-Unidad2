using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Practica2.Models;

namespace Practica2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Abrimos una conexion de la base de datos

            mexicoContext context = new mexicoContext();

            var estados = context.Estados.OrderBy(x => x.Nombre).ToList();
            return View(estados);
        }
    }
}
