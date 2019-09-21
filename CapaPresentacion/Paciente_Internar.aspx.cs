using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class Paciente_Internar : System.Web.UI.Page
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
                Session["MiListaEspecialidad"] = value;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                if (this.LPaciente != null && this.LEspecialidades.Count > 0)
                {
                    foreach (Paciente x in LPaciente)
                    {
                        if (x.especialidad == "")
                        {
                            LdPaciente.Items.Add(x.dni);

                        }

                        
                    }
                    Paciente oPaciente = LPaciente.Find(x => x.dni == LdPaciente.SelectedItem.ToString());
                    txtnombrepaciente.Text = oPaciente.nombre;
                }
              
            }
            
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            LdPaciente.Enabled = false;
            
            Panel1.Visible = true;
            foreach (Especialidad x in LEspecialidades)
            {
                LdEspecialidad.Items.Add(x.nombre);
            }

            ImageButton1.Enabled = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("General_Pacientes.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            LdEspecialidad.Enabled = false;
            Panel2.Visible = true;
            Panel3.Visible = true;
            Especialidad oEspecialidad = LEspecialidades.Find(x => x.nombre == LdEspecialidad.SelectedItem.Text);
            List<Medico> LMedicos = oEspecialidad.verMedicos();
            List<Habitacion> ListaHabitaciones = oEspecialidad.verHabitaciones();
            if ((LMedicos.Count == 0) || (ListaHabitaciones.Count == 00))
            {
                string save = "No Hay Recursos Necesarios (Cargar Medicos o Habitaciones en La especialidad)";
                this.Page.Response.Write("<script language='JavaScript'>window.alert('" + save + "');</script>");
                Server.Transfer("MenuPrincipal.aspx");
            }
            else
            {
                LdHabitacion.Items.Clear();
                LdMedicos.Items.Clear();
                ImageButton2.Enabled = false;
                foreach (Medico x in LMedicos)
                {

                    LdMedicos.Items.Add(x.dni);
                }

                foreach (Habitacion x in ListaHabitaciones)
                {
                    LdHabitacion.Items.Add(x.identificador.ToString());
                }
            }
            Medico oMedico = LMedicos.Find(x => x.dni == LdMedicos.SelectedItem.ToString());
                txtnombreMedico.Text=oMedico.nombre;


        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            LdMedicos.Enabled = false;
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Habitacion oHabitacion = LHabitaciones.Find(X => X.identificador == Convert.ToInt32(LdHabitacion.SelectedItem.ToString()));
            List<Cama>LCamas=oHabitacion.Camasvacias();
            if (LCamas.Count == 0)
            {
                string save = "No Hay Camas Disponibles";
                this.Page.Response.Write("<script language='JavaScript'>window.alert('" + save + "');</script>");
                Server.Transfer("MenuPrincipal.aspx");
            }
            else
            {
                LdCamas.Items.Clear();
                ImageButton6.Visible = true;
                ImageButton4.Enabled = false;
                foreach (Cama x in LCamas)
                {
                    LdCamas.Items.Add(x.ndecama.ToString());

                }

            }
        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            Paciente oPaciente = LPaciente.Find(x => x.dni == LdPaciente.SelectedItem.ToString());
            oPaciente.especialidad = LdEspecialidad.SelectedItem.ToString();
            Especialidad oEspecialidad = LEspecialidades.Find(x => x.nombre == LdEspecialidad.SelectedItem.Text);
            oEspecialidad.AddPaciente(oPaciente);
            List<Medico> LMedicos = oEspecialidad.verMedicos();
            Medico oMedico = LMedicos.Find(x => x.dni == LdMedicos.SelectedItem.ToString());
            oPaciente.medico = oMedico;
            oMedico.AddPaciente(oPaciente);
            List<Habitacion> ListaHabitaciones = oEspecialidad.verHabitaciones();
            Habitacion oHabitacion = LHabitaciones.Find(X => X.identificador == Convert.ToInt32(LdHabitacion.SelectedItem.ToString()));
            List<Cama> LCamas = oHabitacion.Camasvacias();
            Cama oCama = LCamas.Find(x => x.ndecama == Convert.ToInt32(LdCamas.SelectedItem.ToString()));
            oCama.internar(oPaciente);
            string save = "Se Interno al Paciente";
            MapeoCL oMapeo = new MapeoCL();
            oMapeo.GuardarEspecialidadPaciente(oEspecialidad, oPaciente);
            oMapeo.GuardarPacienteMedico(oMedico, oPaciente);
            this.Page.Response.Write("<script language='JavaScript'>window.alert('" + save + "');</script>");
            Server.Transfer("MenuPrincipal.aspx");

        }

        protected void LdPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Paciente oPaciente = LPaciente.Find(x => x.dni == LdPaciente.SelectedItem.ToString());
            txtnombrepaciente.Text = oPaciente.nombre;
        }

        protected void LdMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Especialidad oEspecialidad = LEspecialidades.Find(x => x.nombre == LdEspecialidad.SelectedItem.Text);
            List<Medico> LMedicos = oEspecialidad.verMedicos();
            Medico oMedico = LMedicos.Find(x => x.dni == LdMedicos.SelectedItem.ToString());
                txtnombreMedico.Text=oMedico.nombre;
        }
    }
}