using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class listaPersonas
    {
        public List<clsPersona> listadoPersona()
        {
            /// <summary>
            /// Función que nos devuelve un listado de todas las personas
            /// </summary>
            /// <returns>listaPersonas</returns>
            List<clsPersona> listaPersonas = new List<clsPersona>()
            {
                new clsPersona("Alejandro", "Sosa"),
                new clsPersona("Angel", "Navarro"),
                new clsPersona("Fernando", "Galiana"),
                new clsPersona("Antonio", "Navarro"),
                new clsPersona("Fernando", "Miguel"), 
                new clsPersona("Juanma", "Sanchez"), 
                new clsPersona("Yeray", "Jimenez"),
                new clsPersona("Ruben", "Lindes"),
                new clsPersona("Javier", "Sequera"),
                new clsPersona("David", "Perea")
            };
            return listaPersonas;
        }
    }
}
