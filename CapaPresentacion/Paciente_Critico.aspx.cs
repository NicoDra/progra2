using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class Paciente_Critico : System.Web.UI.Page
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

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
                Paciente oPaciente = LPaciente.Find(x => x.ninternacion == LPaciente.Count);
                if ((txtdroga.Text != "") || (txtsintomas.Text != ""))
                {

                    if (txtdroga.Text != "")
                    {
                        oPaciente.AddnoDroga(txtdroga.Text);
                    }
                    if (txtsintomas.Text != "")
                    {
                        oPaciente.AddnoSintomas(txtsintomas.Text);
                    }
                    txtdroga.Text = "";
                    txtsintomas.Text = "";
                    Button1.Visible = true;
                    string save = "Guardado con Exito";
                    this.Page.Response.Write("<script language='JavaScript'>window.alert('" + save + "');</script>");

                }
                else
                {
                    string save = "Ingrese algun sintoma";
                    this.Page.Response.Write("<script language='JavaScript'>window.alert('" + save + "');</script>");
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("MenuPrincipal.aspx");
        }
    }
}