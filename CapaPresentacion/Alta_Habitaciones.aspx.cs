using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class Alta_Habitaciones : System.Web.UI.Page
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
             lblesp.Text = aux1;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("General_Habitaciones.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int Numer = 1;
                if ((LHabitaciones.Exists(x => x.identificador == Convert.ToInt32(txtident.Text)) == false))
                {

                    Habitacion oHabitacion = new Habitacion();
                    oHabitacion.nhabitacion = Numer;
                    oHabitacion.Ndcamas = Convert.ToInt32(txtnumcam.Text);
                    oHabitacion.especialidad = lblesp.Text;
                    oHabitacion.identificador = Convert.ToInt32(txtident.Text);
                    LHabitaciones.Add(oHabitacion);
                    int b = Convert.ToInt32(txtnumcam.Text);
                    for (int i = 1; i <= b; i++)
                    {
                        lblncama.Text = (Convert.ToInt32(lblncama.Text) + 1).ToString();
                        Cama oCama = new Cama(Convert.ToInt32(lblncama.Text), DropDownList1.SelectedItem.Text);
                        oHabitacion.AddCama(oCama);
                    }
                    Especialidad objespecialidad = LEspecialidades.Find(x => x.nombre == lblesp.Text);
                    objespecialidad.AddHabitacion(oHabitacion);


                }
                else
                {

                    string save = "ESTA habitacion ya fue cargada";
                    this.Page.Response.Write("<script language='JavaScript'>window.alert('" + save + "');</script>");

                }

                Server.Transfer("MenuPrincipal.aspx");
            


            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            
            if (LHabitaciones.Exists(x=>x.identificador==Convert.ToInt32(txtident.Text))==true)
            {
                string save = "ESTA habitacion ya fue cargada";
                this.Page.Response.Write("<script language='JavaScript'>window.alert('" + save + "');</script>");

            }
        }
    }
}