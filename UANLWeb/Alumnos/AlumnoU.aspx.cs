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
    public partial class AlumnoU : System.Web.UI.Page, Access
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (sesionIniciada())
                {
                    int ID = int.Parse(Request.QueryString["pID"]);
                    cargarFacultades();
                    cargarAlumno(ID);
                }
                else
                {
                    Response.Redirect("~/Login.aspx");
                }

            }

        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                modificarAlumno();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Update", "alert('Alumno modificado exitosamente'); window.location='" + Request.ApplicationPath + "./Alumnos/AlumnoR.aspx';", true);

            }
            catch (Exception f)
            {
                ScriptManager.RegisterStartupScript(this, typeof(string), "Error", "alert('" + f.Message + "');", true);

            }

        }

        public void cargarAlumno(int id)
        {
            Alumno_BLL alumBLL = new Alumno_BLL();
            Alumno alum = new Alumno();

            alum = alumBLL.cargarAlumno(id);

            lblMatricula.Text = alum.matricula.ToString();
            txtApellido.Text = alum.apellido.ToString();
            txtNombre.Text = alum.nombre.ToString();
            txtfechaNacimiento.Text = alum.fechaNacimiento.ToString();
            ddlFacultad.SelectedValue = alum.facultad.ToString();
            txtSemestre.Text = alum.semestre.ToString();
        }

        public void modificarAlumno()
        {
            Alumno_BLL alumBLL = new Alumno_BLL();
            Alumno alum = new Alumno();

            alum.matricula = int.Parse(lblMatricula.Text);
            alum.apellido = txtApellido.Text;
            alum.nombre = txtNombre.Text;
            alum.fechaNacimiento = Convert.ToDateTime(txtfechaNacimiento.Text);
            alum.facultad = int.Parse(ddlFacultad.SelectedValue);
            alum.semestre = int.Parse(txtSemestre.Text);

            alumBLL.modificarAlumno(alum);
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
    }
}