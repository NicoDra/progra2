using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class Muestra_Habitacion : System.Web.UI.Page
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

                if (this.LEspecialidades != null && this.LEspecialidades.Count > 0)
                {
                    foreach (Especialidad x in LEspecialidades)
                    {
                        ddl_esp.Items.Add(x.nombre);
                    }
                }


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = LHabitaciones.FindAll(x => x.especialidad == ddl_esp.SelectedItem.ToString()); 
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("General_Habitaciones.aspx");
        }
    }
}