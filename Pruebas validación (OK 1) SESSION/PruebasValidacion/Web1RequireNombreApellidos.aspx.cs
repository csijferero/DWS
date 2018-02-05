using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebasValidacion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, ImageClickEventArgs e)
        {
            Session["Nombre"] = txbNombre.Text;
            Session["Apellidos"] = txbApellidos.Text;
            Response.Redirect("Web2ComparePassword.aspx");
        }
    }
}