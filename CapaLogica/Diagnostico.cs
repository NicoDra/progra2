using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaLogica
{
    public class Diagnostico
    {
        private List<Medicamento> ListaMedicamento;
        private String TextoDiag;

        #region Constructor
        public Diagnostico(String texto)
        {
            this.ListaMedicamento = new List<Medicamento>();
            this.TextoDiag = texto;
        }

        public Diagnostico()
        {
            this.ListaMedicamento = new List<Medicamento>();
            this.TextoDiag = String.Empty;
        }


        #endregion

        #region Propiedades
        public string textodiag
        {
            get
            {
                return this.TextoDiag;
            }
            set
            {
                this.TextoDiag = value;
            }
        }
        #endregion

        #region Metodos



        public void AddMedicamento(Medicamento oMedicamento)
        {
            this.ListaMedicamento.Add(oMedicamento);
        }

     
 
        public override string ToString()
        {
            return "Nombre: " + this.TextoDiag;
        }

        public List<Medicamento> QuitarMedicamentosAgregados(List<Medicamento> aux)
        {
            List<Medicamento> ListaNueva = new List<Medicamento>();
            foreach (Medicamento x in aux)
            {
                bool a = ListaMedicamento.Exists(t => t.nombre == x.nombre);
                if (a ==false)
                {
                    ListaNueva.Add(x);


                }
            }
            if (this.ListaMedicamento.Count == 0)
            {
                return aux;
            }
                return ListaNueva;
        }
        #endregion

    }
}
