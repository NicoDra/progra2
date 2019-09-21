using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class Mostrar_Medicos : System.Web.UI.Page
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
                    foreach (Especialidad x in LEspecialidades)
                    {
                        DropDownList1.Items.Add(x.nombre);
                    }
                }
            }

            }
         


        public Especialidad obespecial(string nomb)
        { Especialidad oEspecialidades = new Especialidad("s");
            foreach(Especialidad x in LEspecialidades){
                if(x.nombre==nomb){
                    oEspecialidades=x;
                }
            }
            return oEspecialidades;
        }

        public void cargarmedicos(Especialidad oEspecialidad)
        {
            GridView1.DataSource = oEspecialidad.verMedicos();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cargarmedicos(obespecial(DropDownList1.SelectedItem.ToString()));
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("General_Medicos.aspx");
        }
    }
}