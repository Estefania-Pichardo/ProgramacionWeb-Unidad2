using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace U2Actividad5Servicios.Models.ViewModels
{
    public class IndexViewModel
    {
        public int Imagen { get; set; }

        public IEnumerable<Clase> Clase { get; set; }
    }
}
