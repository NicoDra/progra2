using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaLogica
{
    public class Cama
    {
        private Paciente oPaciente;
        private int Ndecama;
        private String Tipo;

        
        #region Constructor

        public Cama(Paciente unPaciente, int ndecama, String tipo)
        {
            this.oPaciente = unPaciente;
            this.Ndecama = ndecama;
            this.Tipo = tipo;
        }

 
        public Cama( int ndecama, String tipo)
        {
            this.Ndecama = ndecama;
            this.Tipo = tipo;
            this.oPaciente = new Paciente();
        }

        public Cama()
        {
            this.Ndecama = 0;
            this.Tipo = String.Empty;
            this.oPaciente = new Paciente();
        }
        #endregion

        public int ndecama
        {
            get
            {
                return this.Ndecama;
            }
            set
            {
                this.Ndecama = value;
            }
        }

        public string tipo
        {
            get
            {
                return this.Tipo;
            }
            set
            {
                this.Tipo = value;
            }
        }

        #region Metodos


        public int vacio(int a)
        {
            
            if (oPaciente.nombre == String.Empty)
            {
                return a=0;

            }

            return a;
        }
        public void internar(Paciente unPaciente)
        {
            if (oPaciente.nombre == "")
            {
                this.oPaciente = unPaciente;

            }
            
        }
        public string nombrePcama()
        {
            return this.oPaciente.nombre;

        }

        public void alta()
        {
            Paciente unPaciente = new Paciente();
            int b = oPaciente.Pacientecurado();
            if (b == 1)
            {
                this.oPaciente = unPaciente;
               

            }
            else
            {
     
            }

        }

      

        public override string ToString()
        {
            return "Paciente: " + this.oPaciente.ToString() + "\nNumerodeCama: " + this.ndecama + "\nTipo: " + this.Tipo;
        }

        #endregion
    }
}
