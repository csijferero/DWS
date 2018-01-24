using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Paso_de_Datos
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = "Bienvenido " + Request.Params.Get("txbNombre");
        }

        protected void btnTFN_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm3.aspx?txbNombre=" + Request.Params.Get("txbNombre"));

        }
    }
}