using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaLogica
{
    public class Persona
    {
        private string DNI;
        private string Nombre;
        private string Especialidad;

        #region Constructores


        public Persona()
        {
            this.DNI = string.Empty;
            this.Nombre = string.Empty;
            this.Especialidad = string.Empty;
        }

        public Persona(String dni, string nombre,string especialidad)
        {
            this.DNI = dni;
            this.Nombre = nombre;
            this.Especialidad = especialidad;
        }

        #endregion

        #region Propiedades
        public string dni

        {
            get
            {
                return this.DNI;
            }
            set
            {
                this.DNI = value;
            }
        }

        public string nombre
        {
            get
            {
                return this.Nombre;
            }
            set
            {
                this.Nombre = value;
            }
        }

        public string especialidad
        {
            get
            {
                return this.Especialidad;
            }
            set
            {
                this.Especialidad = value;
            }
        }

        #endregion;

      



    }

   
}
