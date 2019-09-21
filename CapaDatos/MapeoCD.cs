using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatos
{
    public class MapeoCD
    {
        public void AltaEspecialidad(ENTIDADESPECIALIDAD UnEspecialidad)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            MiBase.ENTIDADESPECIALIDAD.InsertOnSubmit(UnEspecialidad);
            MiBase.SubmitChanges();
        }

        public void AltaMedico(ENTIDADMADICO UnMedico)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            MiBase.ENTIDADMADICO.InsertOnSubmit(UnMedico);
            MiBase.SubmitChanges();
        }

        public void AltaPaciente(ENTIDADPACIENTE UnPaciente)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            MiBase.ENTIDADPACIENTE.InsertOnSubmit(UnPaciente);
            MiBase.SubmitChanges();
        }

        public void AltaEspMed(ENTIDADESPECIALIDADMEDICO UnEspMed)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            MiBase.ENTIDADESPECIALIDADMEDICO.InsertOnSubmit(UnEspMed);
            MiBase.SubmitChanges();
        }

        public void AltaPacMed(ENTIDADPACIENTEMEDICO UnEspMed)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            MiBase.ENTIDADPACIENTEMEDICO.InsertOnSubmit(UnEspMed);
            MiBase.SubmitChanges();
        }

        public void AltaEspPaciente(ENTIDADESPECIALIDADPACIENTE UnEspPac)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            MiBase.ENTIDADESPECIALIDADPACIENTE.InsertOnSubmit(UnEspPac);
            MiBase.SubmitChanges();
        }

        public void BorrarRelacionPacMec(ENTIDADPACIENTEMEDICO UnEspMed)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
           ENTIDADPACIENTEMEDICO entidad= MiBase.ENTIDADPACIENTEMEDICO.Single(x => x.DniPaciente == UnEspMed.DniPaciente);
           MiBase.ENTIDADPACIENTEMEDICO.DeleteOnSubmit(entidad);
            MiBase.SubmitChanges();
        }

        public void BorrarRelacionPacEsp(ENTIDADESPECIALIDADPACIENTE UnEspMed)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            ENTIDADESPECIALIDADPACIENTE entidad = MiBase.ENTIDADESPECIALIDADPACIENTE.Single(x => x.DNI_Paciente == UnEspMed.DNI_Paciente);
            MiBase.ENTIDADESPECIALIDADPACIENTE.DeleteOnSubmit(entidad);
            MiBase.SubmitChanges();
        }

       

        public List<CapaDatos.ENTIDADESPECIALIDAD> RecuperarEspecialidads()
        {
            ContextoDataContext contexto = new ContextoDataContext();
            List<CapaDatos.ENTIDADESPECIALIDAD> ListaEspecialidades = new List<CapaDatos.ENTIDADESPECIALIDAD>();
            ListaEspecialidades = (from c in contexto.ENTIDADESPECIALIDAD select c).ToList();
            return ListaEspecialidades;
        }

        public List<CapaDatos.ENTIDADMADICO> RecuperarMedicos()
        {
            ContextoDataContext contexto = new ContextoDataContext();
            List<CapaDatos.ENTIDADMADICO> ListaMedico = new List<CapaDatos.ENTIDADMADICO>();
            ListaMedico = (from c in contexto.ENTIDADMADICO select c).ToList();
            return ListaMedico;
        }

        public List<CapaDatos.ENTIDADPACIENTE> RecuperarPacientes()
        {
            ContextoDataContext contexto = new ContextoDataContext();
            List<CapaDatos.ENTIDADPACIENTE> ListaPaciente = new List<CapaDatos.ENTIDADPACIENTE>();
            ListaPaciente = (from c in contexto.ENTIDADPACIENTE select c).ToList();
            return ListaPaciente;
        }


        public List<CapaDatos.ENTIDADESPECIALIDADPACIENTE> RecuperarEspPaciente()
        {
            ContextoDataContext contexto = new ContextoDataContext();
            List<CapaDatos.ENTIDADESPECIALIDADPACIENTE> ListaEspPac = new List<CapaDatos.ENTIDADESPECIALIDADPACIENTE>();
            ListaEspPac = (from c in contexto.ENTIDADESPECIALIDADPACIENTE select c).ToList();
            return ListaEspPac;
        }

        public List<CapaDatos.ENTIDADPACIENTEMEDICO> RecuperarPacienteMedico()
        {
            ContextoDataContext contexto = new ContextoDataContext();
            List<CapaDatos.ENTIDADPACIENTEMEDICO> ListaPacMec = new List<CapaDatos.ENTIDADPACIENTEMEDICO>();
            ListaPacMec = (from c in contexto.ENTIDADPACIENTEMEDICO select c).ToList();
            return ListaPacMec;
        }
        
        
        //public List<CapaDatos.ENTIDADESPECIALIDADMEDICO> RecuperarEspMed(string nEspecialidad, string mMedico)
        //{
        //    using (ContextoDataContext contexto = new ContextoDataContext)
        //    {
        //        ENTIDADESPECIALIDADMEDICO r = this.(nEspecialidad, mMedico);
        //        return contexto.ENTIDADESPECIALIDADMEDICO.Where(x => x.Nombre_Especialidad == nEspecialidad && x.DNI_Medico == mMedico).ToList();
        //    }
        //}
    }
}