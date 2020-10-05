using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using U2Actividad5Servicios.Models;

namespace U2Actividad5Servicios.Services
{
    public class ClasificacionServices
    {
        public List<Clase> Clasificaciones { get; set; }

        public ClasificacionServices()
        {
            using(animalesContext context=new animalesContext())
            {
                Clasificaciones = context.Clase.OrderBy(x => x.Nombre).ToList();
            }
        }
    }
}
