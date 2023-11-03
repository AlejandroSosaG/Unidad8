using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    public class clsPersona
    {
        #region atributos
        private string nombre;
        private string apellido;
        private DateOnly fechaNac;
        #endregion

        #region constructores
        public clsPersona() {
            this.nombre = "";
            this.apellido = "";
            this.fechaNac = new DateOnly();
        }

        public clsPersona (string nombre, string apellido, DateOnly fecha) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = fecha;
        }
        #endregion

        #region propiedades
            public String Nombre {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Apellido {
            get { return apellido; }
            set { apellido = value; }
        }

        public DateOnly FechaNac
        {
            get { return fechaNac; }
            set { fechaNac = value; }
        }

        public String NombreCompleto {
            get { return $"{nombre} {apellido}"; }
        }
        public String FechaNacimiento
        {
            get { return $"{fechaNac}"; }
        }

        #endregion

    }
}
