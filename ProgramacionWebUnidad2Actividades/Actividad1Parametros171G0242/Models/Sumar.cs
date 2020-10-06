using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actividad1Parametros171G0242.Models
{
    public class Sumar
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }

        public int Resultado()
        {
            return Numero1 + Numero2;
        }
    }
}
