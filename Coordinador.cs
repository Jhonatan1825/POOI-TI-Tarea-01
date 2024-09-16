using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_tarea_01
{
    internal class Coordinador
    {
        public int codigo { get; set; }
        public String nombre { get; set; }
        public int categoria { get; set; }
        public int numero_cel { get; set; }


        public double sueldo_coordinador()
        {
            switch (categoria)
            {
                case 0:
                    return 8500;
                case 1:
                    return 6850;
                case 2:
                    return 5500;
                default:
                    return 0;
            }
        }
    }
}
