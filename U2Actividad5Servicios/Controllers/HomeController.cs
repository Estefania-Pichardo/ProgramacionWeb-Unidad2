using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using U2Actividad5Servicios.Models;
using U2Actividad5Servicios.Models.ViewModels;

namespace U2Actividad5Servicios.Controllers
{

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            animalesContext context = new animalesContext();
            IndexViewModel vm = new IndexViewModel();
            vm.Clase = context.Clase.OrderBy(x => x.Nombre);
            Random r = new Random();
            vm.Imagen = r.Next(1, 6);

            return View(vm);
        }

        [Route("{id}")]
        public IActionResult InfoClase(string id)
        {
            animalesContext context = new animalesContext();
            var nombre = id.Replace("-"," ").ToUpper();

            var animales = context.Clase.Include(x => x.Especies).FirstOrDefault(x => x.Nombre.ToUpper() == nombre);

            if(animales==null)
            {
               return RedirectToAction("Index");
            }
            else 
            {
                return View(animales);
            }
        }
    }
}
