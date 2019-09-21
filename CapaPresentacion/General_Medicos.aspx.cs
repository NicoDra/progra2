using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class General_Medicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("Alta_Medicos.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("MenuPrincipal.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Server.Transfer("Mostrar_Medicos.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Server.Transfer("Agregar_Diagnostico.aspx");
        }
    }
}