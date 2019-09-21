using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica
{
   public class MapeoCL
    {
       public void GuardarEspecialidad(Especialidad ObjEspecialidad)
       {

           ENTIDADESPECIALIDAD EntEsp = new ENTIDADESPECIALIDAD();
           EntEsp.Nombre =ObjEspecialidad.nombre;
           MapeoCD OMapeo = new MapeoCD();
           OMapeo.AltaEspecialidad(EntEsp);
       }

       public List<Especialidad> RecuperarEspecialidad()
       {
           MapeoCD oMapeoCD = new MapeoCD();
           List<Especialidad> ListaEspecialidades = new List<Especialidad>();
           List<CapaDatos.ENTIDADESPECIALIDAD> ListaEntidades = oMapeoCD.RecuperarEspecialidads();
           Especialidad oEspecialidad;

           foreach (CapaDatos.ENTIDADESPECIALIDAD entidad in ListaEntidades)
           {
               if (entidad.Nombre != "")
               {


                   string nombre = entidad.Nombre.ToString();
                   oEspecialidad = new Especialidad(entidad.Nombre);
                       ListaEspecialidades.Add(oEspecialidad);
               }

           }
           return ListaEspecialidades;
       }

        public void GuardarMedico(Medico ObjMedico)
        {
           
         ENTIDADMADICO EntMed = new ENTIDADMADICO ();
            EntMed.DNI = ObjMedico.dni;
            EntMed.Nombre = ObjMedico.nombre;
            EntMed.Especialidad = ObjMedico.especialidad;
           

            MapeoCD OMapeo = new MapeoCD();
            OMapeo.AltaMedico(EntMed);
        }


        public void GuardarPaciente(Paciente ObjPaciente)
        {

            ENTIDADPACIENTE EntPac = new ENTIDADPACIENTE();
            EntPac.DNI = ObjPaciente.dni;
            EntPac.Nombre = ObjPaciente.nombre;
            EntPac.FechaNac =ObjPaciente.fechanac;
            EntPac.Sexo = ObjPaciente.sexo;
            EntPac.ninternacion = ObjPaciente.ninternacion;
            
            MapeoCD OMapeo = new MapeoCD();
            OMapeo.AltaPaciente(EntPac);
        }

        public void GuardarEspecialidadMedico(Especialidad ObjEspecialidad,Medico ObjMedico)
        {

            ENTIDADESPECIALIDADMEDICO EntEspMedi = new ENTIDADESPECIALIDADMEDICO();
            EntEspMedi.Nombre_Especialidad= ObjEspecialidad.nombre;
            EntEspMedi.DNI_Medico = ObjMedico.dni;
            MapeoCD OMapeo = new MapeoCD();
            OMapeo.AltaEspMed(EntEspMedi);
        }

        public void GuardarEspecialidadPaciente(Especialidad ObjEspecialidad, Paciente ObjPaciente)
        {

            ENTIDADESPECIALIDADPACIENTE EntEspMedi = new ENTIDADESPECIALIDADPACIENTE();
            EntEspMedi.Nombre_Especialidad = ObjEspecialidad.nombre;
            EntEspMedi.DNI_Paciente = ObjPaciente.dni;
            MapeoCD OMapeo = new MapeoCD();
            OMapeo.AltaEspPaciente(EntEspMedi);
        }

        public void GuardarPacienteMedico(Medico ObjMedico, Paciente ObjPaciente)
        {

            ENTIDADPACIENTEMEDICO EntMP = new ENTIDADPACIENTEMEDICO();
            EntMP.DniPaciente = ObjPaciente.dni;
            EntMP.DniMedico = ObjMedico.dni;
            MapeoCD OMapeo = new MapeoCD();
            OMapeo.AltaPacMed(EntMP);
        }

        public void BorrarRelacionPacienteMedico(Paciente ObjPaciente)
        {
            ENTIDADPACIENTEMEDICO EntMP = new ENTIDADPACIENTEMEDICO();
            EntMP.DniPaciente = ObjPaciente.dni;
            MapeoCD OMapeo = new MapeoCD();
            OMapeo.BorrarRelacionPacMec(EntMP);
        }
        public void BorrarRelacionPacienteEspecialidad(Paciente ObjPaciente)
        {
            ENTIDADESPECIALIDADPACIENTE EntMP = new ENTIDADESPECIALIDADPACIENTE();
            EntMP.DNI_Paciente = ObjPaciente.dni;
            MapeoCD OMapeo = new MapeoCD();
            OMapeo.BorrarRelacionPacEsp(EntMP);
        }

        public List<Paciente> RecuperarPaciente()
        {
            MapeoCD oMapeoCD = new MapeoCD();
            List<Paciente> ListaPaciente = new List<Paciente>();
            List<CapaDatos.ENTIDADPACIENTE> ListaEntidades = oMapeoCD.RecuperarPacientes();
            Paciente oPaciente;

            foreach (CapaDatos.ENTIDADPACIENTE entidad in ListaEntidades)
            {
                if (entidad.Nombre != "")
                {

                    string dni = entidad.DNI;
                    string nombre = entidad.Nombre.ToString();
                    string sexo =entidad.Sexo;
                    int niternacion=Convert.ToInt32(entidad.ninternacion);
                    DateTime fecha = Convert.ToDateTime(entidad.FechaNac);
                    

                    oPaciente = new Paciente(dni, nombre, niternacion, sexo, fecha,"");
                    ListaPaciente.Add(oPaciente);
                }

            }
            return ListaPaciente;
        }

        public List<Medico> RecuperarMedico()
        {
            MapeoCD oMapeoCD = new MapeoCD();
            List<Medico> ListaMedico = new List<Medico>();
            List<CapaDatos.ENTIDADMADICO> ListaEntidades = oMapeoCD.RecuperarMedicos();
            Medico oMedico;

            foreach (CapaDatos.ENTIDADMADICO entidad in ListaEntidades)
            {
                if (entidad.Nombre != "")
                {

                    string dni = entidad.DNI;
                    string nombre = entidad.Nombre.ToString();
                    string especialidad = entidad.Especialidad;
                    oMedico = new Medico(dni, nombre, especialidad, 0);
                    ListaMedico.Add(oMedico);
                }

            }
            return ListaMedico;
        }

        public Especialidad buscarEspecialidad(List<Especialidad> Lesp, CapaDatos.ENTIDADESPECIALIDADPACIENTE entidads)
        {
            Especialidad oEspecialidad = new Especialidad("o");
            oEspecialidad = Lesp.Find(x => x.nombre == entidads.Nombre_Especialidad);
            return oEspecialidad;

        }

        public Paciente buscarPaciente(List<Paciente> Lpaciente, CapaDatos.ENTIDADESPECIALIDADPACIENTE entidads)
        {
            Paciente oPaciente = new Paciente();
            oPaciente = Lpaciente.Find(x => x.dni == entidads.DNI_Paciente);
            return oPaciente;

        }

        public void RecuperarPacienteporEsp(List<Paciente> Lpac, List<Especialidad> Lesp)
        {
            MapeoCD oMapeoCD = new MapeoCD();
      
            List<Paciente> ListaPaciente = new List<Paciente>();
            
            List<CapaDatos.ENTIDADESPECIALIDADPACIENTE> ListaEntidades = oMapeoCD.RecuperarEspPaciente();
            Paciente oPaciente;

            foreach (CapaDatos.ENTIDADESPECIALIDADPACIENTE entidad in ListaEntidades)
            {
                Especialidad oEspecialidad = buscarEspecialidad(Lesp, entidad);
                if (oEspecialidad.nombre != "o")
                {
                    oPaciente = buscarPaciente(Lpac, entidad);
                    if (oPaciente != null)
                    {  oPaciente.especialidad = oEspecialidad.nombre;
                        oEspecialidad.AddPaciente(oPaciente);
                        
                    }

                }

            }
           
        }

        public void RecuperarPacienteMedico(List<Paciente> Lpac, List<Medico> LMed)
        {
            MapeoCD oMapeoCD = new MapeoCD();

            List<Paciente> ListaPaciente = new List<Paciente>();

            List<CapaDatos.ENTIDADPACIENTEMEDICO> ListaEntidades = oMapeoCD.RecuperarPacienteMedico();
            Paciente oPaciente;
            Medico oMedico;

            foreach (CapaDatos.ENTIDADPACIENTEMEDICO entidad in ListaEntidades)
            {
                oPaciente = Lpac.Find(x => x.dni == entidad.DniPaciente);
                if (oPaciente != null)
                {
                    oMedico = LMed.Find(t => t.dni == entidad.DniMedico);
                        oPaciente.medico=oMedico;
                    oMedico.AddPaciente(oPaciente);
                    
                }
            }
            
            
        }  
       

    }
}
