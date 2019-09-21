using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaLogica
{
    public class Porcentaje
    {
        private string Drogas;
        private double porcentajes;

        public Porcentaje(String drogas, double porcenta)
        {
            this.Drogas = drogas;
            this.porcentajes = porcenta;
        }

        public string drogas
        {
            get
            {
                return this.Drogas;
            }
            set
            {
                this.Drogas = value;
            }
        }

        public double porcenta
        {
            get
            {
                return this.porcentajes;
            }
            set
            {
                this.porcentajes = value;
            }
        }
    }
}
