using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UANL_BLL;

namespace UANLWeb.Alumnos
{
    public partial class AlumnoR : System.Web.UI.Page, Access
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (sesionIniciada())
                {
                    grd_alumnos.DataSource = cargarAlumnos();
                    grd_alumnos.DataBind();

                }
                else
                {
                    Response.Redirect("~/Login.aspx");
                }

            }
        }


        protected void grd_alumnos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                Response.Redirect("~/Alumnos/AlumnoU.aspx?pID=" + e.CommandArgument);
            }
            else
            {
                Response.Redirect("~/Alumnos/AlumnoD.aspx?pID=" + e.CommandArgument);
            }
        }

        public List<object> cargarAlumnos()
        {
            Alumno_BLL alumBLL = new Alumno_BLL();
            List<object> listAlumnos = new List<object>();

            listAlumnos = alumBLL.cargarAlumnos();

            return listAlumnos;

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