using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UANL_BLL;
using UANL_DAL;

namespace UANLWeb
{
    public partial class UsuarioInfo : System.Web.UI.Page, Access
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (sesionIniciada())
                {
                    string username = (string)Session["Usuario"];
                    cargarUsuario(username);
                }
                else
                {
                    Response.Redirect("~/Login.aspx");
                }

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

        public void cargarUsuario(string username)
        {
            Usuario usuario = new Usuario();
            Usuario_BLL usuarioBLL = new Usuario_BLL();
            usuario = usuarioBLL.cargarUsuario(username);

            lblID.Text = usuario.id_Usuario.ToString();
            lblUser.Text = usuario.username.ToString();
            lblPass.Text = usuario.password.ToString();

        }
    }
}