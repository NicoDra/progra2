using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaLogica
{
    public class Paciente : Persona
    {
        private int NInternacion;
        private string Sexo;
        private DateTime FechaNac;
        private Medico Medico;
        private List<Diagnostico> ListaDiagnosticos;
        private List<string> ListadenoDrogas;
        private List<string> ListadenoSintomas;


        #region Constructor

       
        public Paciente(string dni, string nombre,int numero,string sexo,DateTime nac,string especialidad) :base(dni,nombre,especialidad)
        {
            Medico oMedico = new Medico();
            this.NInternacion = numero;
            this.Sexo = sexo;
            this.FechaNac = nac;
            this.Medico = oMedico;   
            this.ListaDiagnosticos = new List<Diagnostico>();     
            this.ListadenoDrogas = new List<string>();
            this.ListadenoSintomas = new List<string>();
        }


        public Paciente()
            : base()
        {
            Medico oMedico = new Medico();
            this.NInternacion = 0;
            this.Sexo = string.Empty;
            this.FechaNac = DateTime.Now;
            this.Medico = oMedico;
            this.ListaDiagnosticos = new List<Diagnostico>();
            this.ListadenoDrogas = new List<string>();
            this.ListadenoSintomas = new List<string>();
        }

        #endregion

        #region Propiedades
        public DateTime fechanac
        {
            get
            {
                return this.FechaNac;
            }
            set
            {
                this.FechaNac = value;
            }
        }

        public Medico medico
        {
            get
            {
                return Medico;
            }
            set
            {
                this.Medico = value;
            }
        }

        public int ninternacion
        {
            get
            {
                return NInternacion;
            }
            set
            {
                this.NInternacion = value;
            }
        }

      

        public string sexo
        {
            get
            {
                return this.Sexo;
            }
            set
            {
                this.Sexo = value;
            }
        }

       
        

      
        #endregion

        #region Metodos
        public void AddDiagnostico(string texto)
        {

            if (this.Medico.nombre != "")
            {

                Diagnostico unDiagnostico = new Diagnostico(texto);
                  this.ListaDiagnosticos.Add(unDiagnostico);
            }
            
           

        }

        public void AddnoDroga(string texto)
        {
            this.ListadenoDrogas.Add(texto);
      

        }

        public void AddnoSintomas(string texto)
        {
                this.ListadenoSintomas.Add(texto);
        }


        public void agregartratamiento(Medicamento oMedicamento){
            Diagnostico oDiagnostico = ultimodiagnostico();
            oDiagnostico.AddMedicamento(oMedicamento);
    }

        

        //public void rescribirdiagnostico(Diagnostico undiagnostico){

        //    ListaDiagnosticos.Add(undiagnostico);
        //}


        public List<Medicamento> TratamientoRecomendados(List<Medicamento> TodosMedicamentos)
        {
            List<Medicamento> aux = MedicamentoRecomendado(TodosMedicamentos);
            aux = Listapordrogas(aux);
            aux = ListaporSintomas(aux);
            
            return aux;
            
        }

        public List<Medicamento> Listapordrogas(List<Medicamento> LMedicamentosRecomendados)
        {
            List<Medicamento> Lista = new List<Medicamento>();
            foreach(Medicamento t in LMedicamentosRecomendados){
                if (t.DrogaComparar(this.ListadenoDrogas)==false)
                {
                    Lista.Add(t);
                }

            }

            return Lista;
           
 
        }
        public List<Medicamento> ListaporSintomas(List<Medicamento> LMedicamentosRecomendados)
        {
            List<Medicamento> Lista = new List<Medicamento>();
            foreach (Medicamento t in LMedicamentosRecomendados)
            {
                if (t.CompararSintoma(this.ListadenoSintomas) == false)
                {
                    Lista.Add(t);
                }

            }

            return Lista;
        }

        public List<Medicamento> MedicamentoRecomendado(List<Medicamento> TodoMedicamento)
        {
            
            List<Medicamento> LMedicamentosRecomendados = new List<Medicamento>();
            Diagnostico oDiagnostico = ultimodiagnostico();
            foreach (Medicamento x in TodoMedicamento)
            {
                if (x.ExisteAccion(oDiagnostico.textodiag) == true)
                {         
                    LMedicamentosRecomendados.Add(x);
                }
            }

            return LMedicamentosRecomendados;

        }


        public Diagnostico ultimodiagnostico()
        {
             
           Diagnostico unDiagnostico = ListaDiagnosticos.Last();
            return unDiagnostico;
        }

        public void ListadeMedicamentos()
        {
            foreach (Diagnostico x in ListaDiagnosticos)
            {
                x.vertratamiento(); 
            }
            

        }
        

        public int Pacientecurado()
        {
            Diagnostico unDiagnostico = new Diagnostico();
            unDiagnostico = ListaDiagnosticos.Last();
            if ((unDiagnostico.textodiag == "alta") || (unDiagnostico.textodiag == "Alta") || (unDiagnostico.textodiag == "ALTA"))
            {
                return 1;

            }

            return 0;
        }

        public int setEdad()
        {
            int edads = DateTime.Now.Year - this.FechaNac.Year;
            DateTime nacimientoAhora = this.FechaNac.AddYears(edads);
            if (DateTime.Now.CompareTo(nacimientoAhora) < 0) { edads--; }
            return edads;
        }

        public string MostrarMedico()
        {
           return this.Medico.ToString();

        }
        

       

        public override string ToString()
        {
            return "Nombre: " + this.nombre + "\nSexo: " + this.Sexo + "\nMedico: " + this.Medico.nombre + "\nNumero de internacion: " + this.NInternacion
                + "\nEdad: " + this.setEdad() ;
        }

        #endregion


    }
}
