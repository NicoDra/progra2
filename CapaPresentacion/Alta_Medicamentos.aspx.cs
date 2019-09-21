using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class Alta_Medicamentos : System.Web.UI.Page
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
            Server.Transfer("General_Medicamentos.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if(txtnombre.Text!=""){
                if (ExisteMedicamento(txtnombre.Text)==false)
                { 
                    Panel1.Visible = true;
                Button1.Visible = false;
                Medicamento oMedicamento = new Medicamento(txtnombre.Text);
                LMedicamentos.Add(oMedicamento);
                txtnombre.Enabled = false;

                }
                else
                {
                    string save = "Este Medicamento ya existe";
                    this.Page.Response.Write("<script language='JavaScript'>window.alert('" + save + "');</script>");
                }
               
                
            }
        }


        public bool ExisteMedicamento(string texto)
        {
            bool a = false;
            return a = LMedicamentos.Exists(t => t.nombre == texto);
        }
        public bool ExisteDroga(string texto)
        {
            bool a = false;
            return a = LDroga.Exists(t => t.nombre == texto);
        }

        public Medicamento TraerMedicamento(string texto)
        {
            Medicamento oMedicamento = this.LMedicamentos.Find(x => x.nombre == texto);
            return oMedicamento;

        }
        public Droga TraerDroga(string texto)
        {
            Droga oDroga = this.LDroga.Find(x => x.nombre == texto);
            return oDroga;

        }

        public void crearDroga()
        {
            Droga oDroga = TraerDroga(txtdroga.Text);
            if (txtaccion.Text != "")
            {
                oDroga.AddAccion(txtaccion.Text);

            }
           
            if (txtcontraindicacion.Text != "")
            { 
                oDroga.AddContradicion(txtcontraindicacion.Text);
            }
           
            txtaccion.Text = string.Empty;
            txtcontraindicacion.Text = string.Empty;

            string save = "Puede Agregar otra o Salir";
            this.Page.Response.Write("<script language='JavaScript'>window.alert('" + save + "');</script>");


        }
        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            if (ExisteDroga(txtdroga.Text) == true)
            {
                string save = "ESTA Droga ya fue cargada";
                this.Page.Response.Write("<script language='JavaScript'>window.alert('" + save + "');</script>");
                Droga oDroga = TraerDroga(txtdroga.Text);
                if ((oDroga.contarA() != 0) || (oDroga.contarC() != 0))
                {Button4.Visible = true;

                }
                
            }else
            {
                string save = "Esta Droga no fue cargada, cargala";
                this.Page.Response.Write("<script language='JavaScript'>window.alert('" + save + "');</script>");
                Droga oDroga= new Droga(txtdroga.Text);
                LDroga.Add(oDroga);
                PanelCrearDroga.Visible = true;
                
            }
            txtdroga.Enabled = false;

            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
                if ((txtcontraindicacion.Text != "") || (txtaccion.Text != ""))
                {

                    crearDroga();
                    Button3.Visible = true;



                }
            }
                
           
       
           
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            
            PanelCrearDroga.Visible = false;
            Button4.Visible = true;

            
            
        }

        

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (txtporcentaje.Text != "")
            {
                Medicamento oMedicamento = TraerMedicamento(txtnombre.Text);
            Droga oDroga = TraerDroga(txtdroga.Text);
            if (oMedicamento.Control(txtdroga.Text) == false)
            {
                oMedicamento.AddDrogas(oDroga, double.Parse(txtporcentaje.Text));
            string save = "Droga Cargada, Cargue otra o vuelva atras";
            this.Page.Response.Write("<script language='JavaScript'>window.alert('" + save + "');</script>");
            Button1.Visible = true;

            }
            else
            {
                string save = "Droga ya fue cargada, cargue otra";
                this.Page.Response.Write("<script language='JavaScript'>window.alert('" + save + "');</script>");
            }
             
            
            txtdroga.Text = "";
            txtdroga.Enabled = true;
            txtporcentaje.Text = "";

            }
            
        }
    }
}