using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaLogica
{
    public class Habitacion
    {
        private int NHabitacion;
        private List<Cama> LCama;
        private string Especialidad;
        private int Identificador;
        private int ndecamas;


        #region Constructor
       public Habitacion(int nhabitacion,int numerocama, String especialidad, int identificador)
        {
            this.NHabitacion = nhabitacion;
            this.ndecamas = numerocama;
            this.LCama = new List<Cama>();
            this.Especialidad = especialidad;
            this.Identificador = identificador;
        }

       public Habitacion()
       {
           this.NHabitacion = 0;
           this.ndecamas = 0;
           this.LCama = new List<Cama>();
           this.Especialidad = string.Empty;
           this.Identificador = -1;
       }

        #endregion

       #region Propiedades
       public String especialidad
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

       public int identificador
       {
           get
           {
               return this.Identificador;
           }
           set
           {
               this.Identificador = value;
           }
       }

       public int nhabitacion
       {
           get
           {
              return this.NHabitacion;
           }
           set
           {
               this.NHabitacion = value;

           }
       }
       

       public int Ndcamas
       {
           get
           {
               return this.ndecamas;
           }
           set
           {
               this.ndecamas = value;
           }
       }
      #endregion

       public int contarlista()
       {
           return this.LCama.Count;
       }
       public void AddCama(Cama oCama)
       {
           if (this.ndecamas > contarlista())
           {
               this.LCama.Add(oCama);

           }
           
               
       }

       public int getnumerodecama()
       {
           int a = 1;
           Cama unCama = this.LCama.Last();
           return a = unCama.ndecama;
       }

       public void buscarcama(Paciente OPaciente)
       { int a=0;
           foreach (Cama c in LCama)
           {
               if (c.vacio(a) == 1)
               {
                   a = 1;
                   c.internar(OPaciente);

               }
           }

       }

       public bool ExistePaciente(string nombre)
       {
           bool a = false;
           a = LCama.Exists(x => x.nombrePcama() == nombre);
           return a;

       }

       public Cama DevolverCama(string nombre)
       {
           Cama oCama = LCama.Find(x => x.nombrePcama() == nombre);
           return oCama;

       }

       public List<Cama> vercamas()
       {
           return this.LCama;
       }

       public List<Cama> Camasvacias()
       {
           List<Cama> LCamas = LCama.FindAll(x => x.nombrePcama() == "");
           return LCamas;
       }


        
    }

   




}

    



    
