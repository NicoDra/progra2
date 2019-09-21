using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaLogica
{
    public class Medicamento
    {
        private string Nombre;
        private List<Droga> Drogas;
        private List<string> Contraindicacion;
        private List<string> AccionTerapeutica;
        private List<Porcentaje> ListaPorcentajes;

        #region Constructores
        public Medicamento()
        {
            this.Nombre = string.Empty;
            this.Drogas = new List<Droga>();
            this.Contraindicacion = new List<string>();
            this.AccionTerapeutica = new List<string>();
            this.ListaPorcentajes = new List<Porcentaje>();

        }
        public Medicamento(string nombre)
        {
            this.Nombre = nombre;
            this.Drogas = new List<Droga>();
            this.Contraindicacion = new List<string>();
            this.AccionTerapeutica = new List<string>();
            this.ListaPorcentajes = new List<Porcentaje>();

        }

        #endregion
        #region Propiedades
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

        public void AddPorcentaje(Porcentaje oPorcentaje)
        {
            this.ListaPorcentajes.Add(oPorcentaje);
        }

        public void AddDrogas(Droga oDroga, double porcentaje)
        {
            
            this.Drogas.Add(oDroga);
            añadirListaAC(oDroga);
            crearporcentaje(oDroga, porcentaje);

        }

        public bool Control(string ladroga)
        {
            bool a = false;

            return a= this.Drogas.Exists(t => t.nombre == ladroga);

        }

        public void crearporcentaje(Droga oDroga, double porcentaje)
        {
            string nombre= oDroga.nombre;
            Porcentaje unPorcentaje = new Porcentaje(nombre, porcentaje);
            AddPorcentaje(unPorcentaje);

        }

        public int contaraccion()
        {
            return this.Contraindicacion.Count;
        }
        public void añadirListaAC(Droga oDroga)
        {  
            List<string> ListaAux=new List<string>();
           ListaAux = oDroga.ConcatenarAccion();
            AddAccion(ListaAux);
            ListaAux = oDroga.ConcatenarContradicion();
            AddContradicion(ListaAux);

            
        }

        public bool DrogaComparar(List<string> contra)
        {
            bool a = false;
            foreach (Droga t in Drogas)
            {
                a=contra.Exists(x => x == t.nombre);
                if (a == true)
                {
                    return a;
                }

            }
            return a;
        }
        public void AddAccion(List<string> aux)
        {
           foreach(string x in aux){

               this.AccionTerapeutica.Add(x);

           }
            


        }
        public List<string> DarLAccion()
        {
            return this.AccionTerapeutica;

        }
        public void AddContradicion(List<string> aux)
        {
            foreach (string x in aux)
            {

                this.Contraindicacion.Add(x);

            }

        }

        public override string ToString()
        {
            return "Nombre: " + this.Nombre;
        }

    

        public bool CompararSintoma(List<string> contra)
        {
            bool a = false;
            foreach (string t in Contraindicacion)
            {
                a = contra.Exists(x => x == t);
                if (a == true)
                {
                    return a;
                }

            }
            return a;

            }

        public bool ExisteAccion(string texto)
        {
            bool a = false;
           return a=AccionTerapeutica.Exists(t => t == texto);
        }

        
        

        #endregion
    }
}
