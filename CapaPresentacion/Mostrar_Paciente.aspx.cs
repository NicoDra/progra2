using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class Mostrar_Paciente : System.Web.UI.Page
    {
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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (this.LPaciente != null && this.LPaciente.Count > 0)
                {
                    GridView1.DataSource = this.LPaciente;
                    GridView1.DataBind();
                }
                if (this.LEspecialidades != null && this.LEspecialidades.Count > 0)
                {
                    foreach (Especialidad x in LEspecialidades)
                    {
                        DropDownList1.Items.Add(x.nombre);
                    }

                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("General_Pacientes.aspx");

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Especialidad oEspecialidad=LEspecialidades.Find(x=>x.nombre==DropDownList1.SelectedItem.ToString());
         GridView1.DataSource = oEspecialidad.verPacientes();
         GridView1.DataBind();
        }
    }
}