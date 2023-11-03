using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    public class listaPersonas
    {
        public List<clsPersona> ListadoPersona()
        {
            /// <summary>
            /// Función que nos devuelve un listado de todas las personas
            /// </summary>
            /// <returns>listaPersonas</returns>
            List<clsPersona> listaPersonas = new List<clsPersona>()
            {
                new clsPersona("Alejandro", "Sosa", new DateOnly(2001, 8, 26)),
                new clsPersona("Angel", "Navarro", new DateOnly(2002, 10, 5)),
                new clsPersona("Fernando", "Galiana", new DateOnly(1957, 10, 10)),
                new clsPersona("Antonio", "Navarro", new DateOnly(2003, 5, 25)),
                new clsPersona("Fernando", "Miguel", new DateOnly(2003, 4, 14)), 
                new clsPersona("Juanma", "Sanchez", new DateOnly(2003, 1, 18)), 
                new clsPersona("Yeray", "Jimenez", new DateOnly(2003, 11, 28)),
                new clsPersona("Ruben", "Lindes", new DateOnly(2002, 7, 23)),
                new clsPersona("Javier", "Sequera", new DateOnly(2001, 9, 7)),
                new clsPersona("David", "Perea", new DateOnly(189, 11, 25))
            };
            return listaPersonas;
        }
    }
}
