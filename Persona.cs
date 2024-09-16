using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_tarea_01
{
    internal class Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public double estatura { get; set; }
        public double peso { get; set; }

        //-	Un método que retorne el estado de la persona 
        public string estado_persona()
        {
            if (edad < 18)
            {
                return "menor de edad";
            }
            else
            {
                return "mayor de edad";
            }
        }
        public double CalcularIMC()
        {
            // Fórmula del IMC: peso / (estatura al cuadrado)
            return peso / (estatura*estatura);
        }
    }
}
