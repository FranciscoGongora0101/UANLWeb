using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UANL_DAL;
using UANL_BLL;

namespace UANLWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {}

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            if (usuarioValido())
            {
                Response.Redirect("~/Alumnos/AlumnoR.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Sesion", "alert('El usuario y/o contraseña son invalidos.')", true);
            }

        }


        public bool usuarioValido()
        {
            bool acceso = false;

            Usuario_BLL userBLL = new Usuario_BLL();
            Usuario user = new Usuario();

            user = userBLL.consultarUsuario(txtUsuario.Text, txtContraseña.Text);

            if (user != null)
            {
                Session["Usuario"] = user.username;
                Session["ID"] = user.id_Usuario;
                acceso = true;
            }

            return acceso;

        }
    }
}