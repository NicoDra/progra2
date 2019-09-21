using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class Alta_Pacientes : System.Web.UI.Page
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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblnumero.Text = (LPaciente.Count).ToString();
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string b = Convert.ToString(Text1.Value);
            DateTime dateValue;
            if (Page.IsValid)
            {

                if (txtdnipaciente.Text != "")
                {
                    if (txtnombre.Text != "")
                    {
                        if (DateTime.TryParse(b, out dateValue))
                        {

                            if ((LPaciente.Exists(x => x.dni == txtdnipaciente.Text) == false))
                            {
                                if ((LMedicos.Exists(x => x.dni == txtdnipaciente.Text) == false)) { 
                                int a = Convert.ToInt32(lblnumero.Text) + 1;
                                Paciente oPaciente = new Paciente(txtdnipaciente.Text, txtnombre.Text, a, LalistaMS.SelectedItem.ToString(), Convert.ToDateTime(Text1.Value), "");
                                lblnumero.Text = a.ToString();
                                LPaciente.Add(oPaciente);
                                MapeoCL oMapeo = new MapeoCL();
                                oMapeo.GuardarPaciente(oPaciente); //graba en la base de datos

                                string save = "ESETE PACIENTE FUE CARGADO";
                                this.Page.Response.Write("<script language='JavaScript'>window.alert('" + save + "');</script>");
                                if (DropDownList1.SelectedItem.Text == "SI")
                                {
                                    Server.Transfer("Paciente_Critico.aspx");
                                }
                                }
                               
                            }
                            else
                            {
                                string save = "ESE DNI YA FUE CARGADO";
                                this.Page.Response.Write("<script language='JavaScript'>window.alert('" + save + "');</script>");


                            }
                            txtdnipaciente.Text = "";
                            txtnombre.Text = "";

                        }   
             

                    }
                }

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("General_Pacientes.aspx");
        }
    }
}