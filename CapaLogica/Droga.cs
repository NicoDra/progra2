using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaLogica
{
    public class Droga
    {
        private string Nombre;
        private List<String> Accion;
        private List<string> Contraindicacion;

        #region Constructor
        public Droga(string nombre)
        {
            this.Nombre = nombre;
            this.Accion=new List<string>();
            this.Contraindicacion = new List<string>();

        }

        public Droga()
        {
            this.Nombre = string.Empty;
            this.Accion = new List<string>();
            this.Contraindicacion = new List<string>();

        }

        #endregion

        #region propiedades
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
        #endregion

        #region Metodos
        public void AddAccion(string accion)
        {
            this.Accion.Add(accion);

        }

        public void AddContradicion(string contradicion)
        {
            this.Contraindicacion.Add(contradicion);

        }

        public List<string> ConcatenarAccion()
        {
            return this.Accion;
        }

        public List<string> ConcatenarContradicion()
        {
            return this.Contraindicacion;
        }

        public int contarA()
        {
            int a = this.Accion.Count;
            return a;
        }

        public int contarC()
        {
            int a = this.Contraindicacion.Count;
            return a;
        }
        #endregion


    }


}
