using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaLogica
{
    public class Especialidad
    {
        private String Nombre;
        private System.Collections.Generic.List<Habitacion> ListaHabitaciones;
        private System.Collections.Generic.List<Medico> ListaMedicos;
        private System.Collections.Generic.List<Paciente> ListaPacientes;


        #region Constructor 
        public Especialidad(string nombre) {
        this.Nombre = nombre;
        this.ListaHabitaciones= new List<Habitacion>();
        this.ListaMedicos = new List<Medico>();
        this.ListaPacientes = new List<Paciente>();
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
        public void AddHabitacion(Habitacion oHabitacion)
        {
            if (oHabitacion.especialidad == this.Nombre)
            {
                this.ListaHabitaciones.Add(oHabitacion);
            }

        }

        public Cama BuscarPacienteHabitacion(Paciente oPaciente)
        {
            Cama oCama = new Cama();

            foreach (Habitacion x in ListaHabitaciones)
            {
                if (x.ExistePaciente(oPaciente.nombre))
                {
                    oCama = x.DevolverCama(oPaciente.nombre);
                }

            }

            return oCama;

        }

        public void AddPaciente(Paciente oPersona)
        {
            if (oPersona.especialidad == this.Nombre)
            {
                this.ListaPacientes.Add(oPersona);
            }
            
        }

        public void AddMedicos(Medico oPersona)
        {
            if (oPersona.especialidad == this.Nombre)
            {
                this.ListaMedicos.Add(oPersona);
            }

        }

        public void RemoveMedicos(string dnis)
        {
            Medico oMedico = new Medico();
            oMedico = this.ListaMedicos.Find(Medico => Medico.dni == dnis);
            if (oMedico.dni == dnis)
            {
                ListaMedicos.Remove(oMedico);

            }

        }

        public void RemovePacientes(string dnis)
        {
            Paciente oPaciente = new Paciente();
            oPaciente = this.ListaPacientes.Find(x => x.dni == dnis);
            if (oPaciente.dni == dnis)
            {
                ListaPacientes.Remove(oPaciente);
            }
        }

        public void RemoverHabitacion(int identificadore)
        {
            Habitacion unHabitacion = new Habitacion();
            unHabitacion = this.ListaHabitaciones.Find(unaHabitacion=> unaHabitacion.identificador == identificadore);
            if (unHabitacion.identificador == identificadore)
            {
                ListaHabitaciones.Remove(unHabitacion);

            }

        }


        public override string ToString()
        {
            return "Nombre: " + this.nombre;
        }



        //public int getnumerodehabitacion()
        //{
        //    Habitacion oHabitacion = 
            
        //}

        public void camadisponible(Paciente unPaciente)
        {
            foreach (Habitacion p in ListaHabitaciones)
            {
                p.buscarcama(unPaciente);

            }


        }
        public List<Habitacion> verHabitaciones()
        {
            return this.ListaHabitaciones;

        }

        public List<Medico> verMedicos()
        {
            return this.ListaMedicos;

        }

        public List<Paciente> verPacientes()
        {
            return this.ListaPacientes;

        }

        public bool comparardni(string texto)
        {
            foreach (Persona x in ListaPacientes)
            {
                if (texto == x.dni)
                {
                    return true;

                }

            }
            return false;
        }

        #endregion

        
        

    }
}
