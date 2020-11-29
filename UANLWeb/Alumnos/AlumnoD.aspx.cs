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
    public partial class AlumnoD : System.Web.UI.Page, Access
    {
        protected void Page_Load(object sender, EventArgs e)
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

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarAlumno();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Registro", "alert('Alumno eliminado existosamente'); window.location='" + Request.ApplicationPath + "./Alumnos/AlumnoR.aspx';", true);
        }

        public void cargarAlumno(int id)
        {
            Alumno_BLL alumBLL = new Alumno_BLL();
            Alumno alum = new Alumno();

            alum = alumBLL.cargarAlumno(id);

            lblMatricula.Text = alum.matricula.ToString();
            lblApellido.Text = alum.apellido.ToString();
            lblNombre.Text = alum.nombre.ToString();
            lblFechaNacimiento.Text = alum.fechaNacimiento.ToString();
            ddlFacultad.SelectedValue = alum.facultad.ToString();
        }

        public void eliminarAlumno()
        {
            Alumno_BLL alumBLL = new Alumno_BLL();

            int matricula = int.Parse(lblMatricula.Text);

            alumBLL.eliminarAlumno(matricula);
        }

        public void cargarFacultades()
        {

            Facultad_BLL FacuBLL = new Facultad_BLL();
            List<Facultad> listFacultades = new List<Facultad>();

            listFacultades = FacuBLL.cargarFacultades();

            ddlFacultad.DataSource = listFacultades;
            ddlFacultad.DataTextField = "nombre";
            ddlFacultad.DataValueField = "id_Facultad";
            ddlFacultad.DataBind();

            ddlFacultad.Items.Insert(0, new ListItem("----Seleccione Universidad----", "0"));




        }
    }
    
}