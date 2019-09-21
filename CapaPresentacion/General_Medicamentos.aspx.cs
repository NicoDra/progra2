using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaLogica;

namespace CapaPresentacion
{

    public partial class General_Medicamentos : System.Web.UI.Page
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
                Session["MiListaDrogas"] = value;
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


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("MenuPrincipal.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("Alta_Medicamentos.aspx");
        }
    }
}