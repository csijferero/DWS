using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebasValidacion
{
    public partial class WebFormPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //TextBox enviaNombre = (TextBox)Page.PreviousPage.FindControl("txbNombre");
            //TextBox enviApellidos = (TextBox)Page.PreviousPage.FindControl("txbApellidos");

            //lbNombre.Text = enviaNombre.Text;
            //lbApellidos.Text = enviApellidos.Text;

            if (!Page.IsPostBack)
            {
                lbNombre.Text = Request.Params.Get("nombre");
                lbApellidos.Text = Request.Params.Get("apellidos");
            }
        }

    }
}