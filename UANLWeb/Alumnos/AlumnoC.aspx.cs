using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UANL_BLL;
using UANL_DAL;

namespace UANLWeb.Alumnos
{
    public partial class AlumnoC : System.Web.UI.Page, Access
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (sesionIniciada())
                {
                    cargarFacultades();
                }
                else
                {
                    Response.Redirect("~/Login.aspx");
                }

            }

        }

        public void agregarAlumno()
        {
            Alumno_BLL alumBLL = new Alumno_BLL();
            Alumno alumno = new Alumno();

            alumno.matricula = int.Parse(txtMatricula.Text);
            alumno.nombre = txtNombre.Text;
            alumno.apellido = txtApellido.Text;
            alumno.fechaNacimiento = Convert.ToDateTime(txtfechaNacimiento.Text);
            alumno.facultad = int.Parse(ddlFacultad.SelectedValue);
            alumno.semestre = int.Parse(txtSemestre.Text);

            try
            {
                alumBLL.agregarAlumno(alumno);
                limpiarCampos();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Registro", "alert('Alumno creado existosamente'); window.location='" + Request.ApplicationPath + "./Alumnos/AlumnoR.aspx';", true);

            }

            catch (Exception e)
            {
                ScriptManager.RegisterStartupScript(this, typeof(string), "Error", "alert('" + e.Message + "');", true);
            }



        }

        public void cargarFacultades()
        {

            Facultad_BLL facuBLL = new Facultad_BLL();
            List<Facultad> listFacultades = new List<Facultad>();

            listFacultades = facuBLL.cargarFacultades();

            ddlFacultad.DataSource = listFacultades;
            ddlFacultad.DataTextField = "nombre";
            ddlFacultad.DataValueField = "id_Facultad";
            ddlFacultad.DataBind();

            ddlFacultad.Items.Insert(0, new ListItem("----Seleccione Facultad----", "0"));




        }

        public void limpiarCampos()
        {
            txtMatricula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtfechaNacimiento.Text = "";
            ddlFacultad.SelectedIndex = 0;
            txtSemestre.Text = "";
        }



        public bool sesionIniciada()
        {
            if (Session["Usuario"] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarAlumno();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alta", "alert('Alumno agregado existosamente.')", true);
        }
    }
}