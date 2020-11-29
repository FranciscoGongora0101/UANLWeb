using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UANLWeb
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["Usuario"] != null)
                    PanelUser.Text = Session["Usuario"].ToString();

            }
        }

        protected void logout(object sender, EventArgs e)
        {
            Session["Usuario"] = null;
            Session["ID"] = null;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Logout", "alert('Acaba de cerrar sesion. Vuelva Pronto!'); window.location='" + Request.ApplicationPath + "../Login.aspx';", true);

        }
    }
}