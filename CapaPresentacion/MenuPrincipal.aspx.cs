using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class MenuPrincipal : System.Web.UI.Page
    {
        public List<Especialidad> LEspecialidades
        {
            get
            {
                if (Session["ListaEspecialidad"] == null)
                    Session["ListaEspecialidad"] = new List<Especialidad>();
                return (List<Especialidad>)Session["ListaEspecialidad"];
            }
            set
            {
                Session["ListaEspecialidad"] = value;
            }
        }

        public List<Droga> LDroga
        {
            get
            {
                if (Session["ListaDrogas"] == null)
                    Session["ListaDrogas"] = new List<Droga>();
                return (List<Droga>)Session["ListaDrogas"];
            }
            set
            {
                Session["ListaDrogas"] = value;
            }
        }

        public List<Medicamento> LMedicamentos
        {
            get
            {
                if (Session["ListaMedicamentos"] == null)
                    Session["ListaMedicamentos"] = new List<Medicamento>();
                return (List<Medicamento>)Session["ListaMedicamentos"];
            }
            set
            {
                Session["ListaMedicamiento"] = value;
            }
        }

        public List<Paciente> LPaciente
        {
            get
            {
                if (Session["MiListaPaciente"] == null)
                    Session["MiListaPaciente"] = new List<Paciente>();
                return (List<Paciente>)Session["MiListaPaciente"];
            }
            set
            {
                Session["MiListaPaciente"] = value;
            }
        }
        public List<Habitacion> LHabitaciones
        {
            get
            {
                if (Session["MiListaHabitacion"] == null)
                    Session["MiListaHabitacion"] = new List<Habitacion>();
                return (List<Habitacion>)Session["MiListaHabitacion"];
            }
            set
            {
                Session["MiListaHabitacion"] = value;
            }
        }

        public List<Medico> LMedicos
        {
            get
            {
                if (Session["MiListaMedico"] == null)
                    Session["MiListaMedico"] = new List<Medico>();
                return (List<Medico>)Session["MiListaMedico"];
            }
            set
            {
                Session["MiListaMedico"] = value;
            }
        }


        public List<Medico> buscarMed(Especialidad oEspecialidad)
        {
            List<Medico> LMedico = LMedicos.FindAll(x => x.especialidad == oEspecialidad.nombre);
            return LMedico;
        }
        public void CargarMedEsp()
        {
            foreach (Especialidad x in LEspecialidades)
            {

                List<Medico> LISTAMedico=buscarMed(x);
                if (LISTAMedico!=null)
                {
                    x.ModificarListaM(LISTAMedico);
                }
                


            }

        }

        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.LEspecialidades.Count == 0)
            {
                MapeoCL oMapeo = new MapeoCL();
                LEspecialidades = oMapeo.RecuperarEspecialidad();
                LMedicos = oMapeo.RecuperarMedico();
                CargarMedEsp();
                LPaciente = oMapeo.RecuperarPaciente();
                oMapeo.RecuperarPacienteporEsp(LPaciente, LEspecialidades);
                oMapeo.RecuperarPacienteMedico(LPaciente,LMedicos);

                Droga oDroga = new Droga("acelsalicico");
                oDroga.AddAccion("dolor de cabeza");
                Medicamento oMedicamento = new Medicamento("Aspirina");
                oMedicamento.AddDrogas(oDroga, 40);
                LMedicamentos.Add(oMedicamento);
                LDroga.Add(oDroga);

            }
                    
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
        {
            Server.Transfer("GeneralEspecialidad.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Server.Transfer("General_Medicos.aspx");
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            Server.Transfer("General_Medicamentos.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Server.Transfer("General_Habitaciones.aspx");
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Server.Transfer("General_Pacientes.aspx");
        }
    }
}