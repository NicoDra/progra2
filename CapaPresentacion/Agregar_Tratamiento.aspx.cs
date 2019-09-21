using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class Agregar_Tratamiento : System.Web.UI.Page
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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (this.LEspecialidades != null && this.LEspecialidades.Count > 0)
                {
                    foreach (Especialidad x in LEspecialidades)
                    {
                        LaListadEspecialidad.Items.Add(x.nombre);
                    }
                }
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Panel1.Visible = true;
            DropMedicos.Items.Clear();
            Especialidad oEspecialidad = LEspecialidades.Find(x => x.nombre == LaListadEspecialidad.SelectedItem.ToString());
            List<Medico> ListaMedicos = oEspecialidad.verMedicos();
            if (ListaMedicos.Count == 0)
            {
                string save = "No hay Medicos en esta especialidad";
                this.Page.Response.Write("<script language='JavaScript'>window.alert('" + save + "');</script>");
                Server.Transfer("MenuPrincipal.aspx");
            }
            else
            {
                foreach (Medico x in ListaMedicos)
                {
                    DropMedicos.Items.Add(x.dni);
                }
                Medico oMedico = ListaMedicos.Find(x => x.dni == DropMedicos.SelectedItem.ToString());
                txtnombreMedico.Text = oMedico.nombre;
            }
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            if (Page.IsValid)
            {
                Especialidad oEspecialidad = LEspecialidades.Find(x => x.nombre == LaListadEspecialidad.SelectedItem.ToString());
                List<Medico> ListaMedicos = oEspecialidad.verMedicos();
                Medico oMedico = ListaMedicos.Find(x => x.dni == DropMedicos.SelectedItem.ToString());
                if (oMedico.ExistePaciente(txtdni.Text) == true)
                {
                    string save = "Paciente Encontrado";
                    this.Page.Response.Write("<script language='JavaScript'>window.alert('" + save + "');</script>");
                    DropMedicos.Enabled = false;
                    txtdni.Enabled = false;
                    LaListadEspecialidad.Enabled = false;
                    Panel2.Visible = true;
                    Paciente oPaciente = LPaciente.Find(x => x.dni == txtdni.Text);
                    Diagnostico oDiagnostico = oPaciente.ultimodiagnostico();
                    if ((oDiagnostico.textodiag != "") || (oDiagnostico.textodiag != "ALTA"))
                    {
                        txtdiagnostico.Text = oDiagnostico.textodiag;
                        List<Medicamento> MedicamentosRecomendados = oPaciente.TratamientoRecomendados(LMedicamentos);
                        MedicamentosRecomendados = oPaciente.MedicamentosYaAgregados(MedicamentosRecomendados);
                        if (MedicamentosRecomendados.Count != 0)
                        {
                            DropMedicamentos.Items.Clear();
                            foreach (Medicamento x in MedicamentosRecomendados)
                            {
                                DropMedicamentos.Items.Add(x.nombre);
                            }
                        }
                        else
                        {
                            save = "No hay medicamentos recomendados";
                            this.Page.Response.Write("<script language='JavaScript'>window.alert('" + save + "');</script>");
                            Server.Transfer("MenuPrincipal.aspx");
                        }
                    }
                }
                else
                {
                    string save = "Ese DNI no fue encontrado";
                    this.Page.Response.Write("<script language='JavaScript'>window.alert('" + save + "');</script>");

                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("MenuPrincipal.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Paciente oPaciente = LPaciente.Find(x => x.dni == txtdni.Text);
            Diagnostico oDiagnostico = oPaciente.ultimodiagnostico();
           
            
                Medicamento oMedicamento = LMedicamentos.Find(x => x.nombre == DropMedicamentos.Text);
                DropMedicamentos.Items.Remove(DropMedicamentos.Text);
                oDiagnostico.AddMedicamento(oMedicamento);
                if (DropMedicamentos.Items.Count == 0)
                {
                    string save = "No hay medicamentos recomendados";
                    this.Page.Response.Write("<script language='JavaScript'>window.alert('" + save + "');</script>");
                    Server.Transfer("MenuPrincipal.aspx");

                }
            
            
          
        }

        protected void DropMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Especialidad oEspecialidad = LEspecialidades.Find(x => x.nombre == LaListadEspecialidad.SelectedItem.Text);
            List<Medico> LMedicos = oEspecialidad.verMedicos();
            Medico oMedico = LMedicos.Find(x => x.dni == DropMedicos.SelectedItem.ToString());
            txtnombreMedico.Text = oMedico.nombre;
        }
    }
}