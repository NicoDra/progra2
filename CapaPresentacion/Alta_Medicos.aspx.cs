using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class Alta_Medicos : System.Web.UI.Page
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
            if (!IsPostBack)
            {

                if (this.LEspecialidades != null && this.LEspecialidades.Count > 0)
                {
                    foreach (Especialidad x in LEspecialidades)
                    {
                        Lalista.Items.Add(x.nombre);
                    }
                   
                }
            }

        }

        
        private bool existedni(string texto){
            foreach (Especialidad x in LEspecialidades)
            {
                if (x.comparardnis(texto) == true)
                {
                    return true;
                }

            }
            return false;

    }
       
        protected void Cargar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                if (LMedicos.Exists(x => x.dni == txtdnimedico.Text) == false)
                {
                    if (LPaciente.Exists(x => x.dni == txtdnimedico.Text)== false)
                    {
                        Medico oMedico = new Medico(txtdnimedico.Text, txtnombremedico.Text, Lalista.SelectedItem.ToString(), 0);
                        Especialidad oEspecialidad = LEspecialidades.Find(x => x.nombre == Lalista.SelectedItem.ToString());
                        oEspecialidad.AddMedicos(oMedico);
                        LMedicos.Add(oMedico);
                        MapeoCL oMapeo = new MapeoCL();
                        oMapeo.GuardarEspecialidadMedico(oEspecialidad, oMedico);//graba en la base de datos
                        oMapeo.GuardarMedico(oMedico);
                        string save = "CARGA CON EXITO";
                        this.Page.Response.Write("<script language='JavaScript'>window.alert('" + save + "');</script>");

                    }
                    else
                    {
                        string save = "ESE DNI YA FUE CARGADO";
                        this.Page.Response.Write("<script language='JavaScript'>window.alert('" + save + "');</script>");


                    }


                }
                else
                {
                    string save = "ESE DNI YA FUE CARGADO";
                    this.Page.Response.Write("<script language='JavaScript'>window.alert('" + save + "');</script>");
                }
                txtdnimedico.Text = string.Empty;
                txtnombremedico.Text = string.Empty;
            }
           
        }

        protected void Volver_Click(object sender, EventArgs e)
        {
            Server.Transfer("General_Medicos.aspx");
        }
    }
}