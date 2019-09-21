using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class Crear_Especialidad : System.Web.UI.Page
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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (this.LEspecialidades != null && this.LEspecialidades.Count > 0)
                {
                    CargarEspecialidad();
                }
            }
        }

        private void CargarEspecialidad()
        {
            GridView1.DataSource = this.LEspecialidades;
            GridView1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtnombreesp.Text != "")
            {
                if (Page.IsValid)
                {
                    Especialidad oEspecialidad = new Especialidad(txtnombreesp.Text);
                    LEspecialidades.Add(oEspecialidad);
                    CargarEspecialidad();
                    txtnombreesp.Text = string.Empty;
                }
                

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("GeneralEspecialidad.aspx");
        }
    }
}