using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class Borrar_Especialidad : System.Web.UI.Page
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

        private void CargarEspecialidad()
        {
            GridView1.DataSource = this.LEspecialidades;
            GridView1.DataBind();

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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aux1 = GridView1.SelectedRow.Cells[1].Text;
            Especialidad oEspecialidad = LEspecialidades.Find(x => x.nombre == aux1);


            if (LEspecialidades.Exists(x => x.nombre == aux1))
            {
                LEspecialidades.Remove(oEspecialidad);
                CargarEspecialidad();
                string save = "LA ESPECIALIDAD FUE ELIMINADA";
                this.Page.Response.Write("<script language='JavaScript'>window.alert('" + save + "');</script>");
            }
        }

       

        public Especialidad Comparar(string texto)
        {
            Especialidad oEspecialidad = new Especialidad("o");
            foreach (Especialidad x in LEspecialidades)
            {
                if (x.nombre == texto)
                {
                    oEspecialidad = x;
                    return oEspecialidad;
                }

                
            }
            return oEspecialidad;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("GeneralEspecialidad.aspx");
        }
    }
}