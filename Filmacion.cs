using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_tarea_01
{
    internal class Filmacion
    {
        public int codigo { get; set; }
        public string titulo { get; set; }
        public int duracion_min {get; set;}
        public double precio_soles {get; set;}


        public double precio_dolares()
        {
            return precio_soles / 3.59;
        }

    }
}
