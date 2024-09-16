using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_tarea_01
{
    internal class Program
    {

        /*
                  Filmacion filmacion = new Filmacion();
                  filmacion.duracion_min = 30;
                  filmacion.precio_soles = 50;

              imprimir("COSTOS POR FILMACIÓN");
              imprimir ( "Duracion de la filmacion = "+ filmacion.duracion_min);
              imprimir ( " Precio en soles = " +  filmacion.precio_soles);
              imprimir(" Precio en Dolares =" + filmacion.precio_dolares());
                  */

        static void Main(string[] args)
        {
            /*
                        Persona persona = new Persona();
                        persona.nombre = "Alejandra";
                        persona.apellido = "Garcia";
                        persona.edad = 25;
                        persona.estatura = 1.75;
                        persona.peso = 65;

                        imprimir("Datos de una Persona");
                        imprimir("Nombre: " +  persona.nombre);
                        imprimir("Apellido: " + persona.apellido); 
                        imprimir("EDAD: " + persona.edad);
                        imprimir("Estatura:" + persona.estatura);
                        imprimir("Peso:"+ persona.peso);
                        imprimir("Estado de la Persona: " + persona.estado_persona());
                        imprimir("IMC de la Persona:" + persona.CalcularIMC());
            */
       

            Coordinador coordinador = new Coordinador();
            coordinador.codigo = 003;
            coordinador.nombre = "Carlos";
            coordinador.categoria = 2;
            coordinador.numero_cel = 943242344;

            imprimir("Datos Del Coordinador");
            imprimir(" Codigo : " + coordinador.codigo);
            imprimir(" Nombre : "+  coordinador.nombre); 
            imprimir("Categoria : "+ coordinador.categoria);
            imprimir("Sueldo del Coordinador : " + coordinador.sueldo_coordinador());
            imprimir("Numero de Celular : "+ coordinador.numero_cel);




            Console.ReadKey();
        }

        public static void imprimir(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
