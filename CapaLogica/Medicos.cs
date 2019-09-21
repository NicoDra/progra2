using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaLogica
{
    public class Medico : Persona
    {
        
        private System.Collections.Generic.List<Paciente> LPacientes;

        #region Constructor
        public Medico(String dni, string nombre, String especialidad, int identificador): base(dni,nombre,especialidad)
        {
        
            this.LPacientes = new List<Paciente>();
        }

        public Medico()
            : base()
        {

            this.LPacientes = new List<Paciente>();
        }

        #endregion

        #region Metodos
        public void AddPaciente(Paciente wPaciente)
        {
            this.LPacientes.Add(wPaciente);
        }
        
        public void RemoverPaciente(string dnis)
        {
            Paciente oPaciente = new Paciente();
            oPaciente = this.LPacientes.Find(x => x.dni == dnis);
            if (oPaciente.dni == dnis)
            {
                LPacientes.Remove(oPaciente);
            }

        }

        public override string ToString()
        {
            return "Nombre: " + this.nombre + "\nDni: " + this.dni + "\nEspecialidad " + this.especialidad;
        }


        public int cantidadpacientes()
        {
            return this.LPacientes.Count;

        }

        public Paciente buscarpaciente(string dnis)
        {

            Paciente oPaciente = new Paciente();
            oPaciente = this.LPacientes.Find(x => x.dni == dnis);
            return oPaciente;
        }

        public bool ExistePaciente(string dnis)
        {

            bool a = false;
            a = this.LPacientes.Exists(x => x.dni == dnis);
            return a;
        }
   

        #endregion

    }
}
