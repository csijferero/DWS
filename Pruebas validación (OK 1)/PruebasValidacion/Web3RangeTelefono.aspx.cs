using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebasValidacion
{
    public partial class WebFormTelefono : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Label enviaNombre = (Label)Page.PreviousPage.FindControl("lbNombre");
                Label enviApellidos = (Label)Page.PreviousPage.FindControl("lbApellidos");
                TextBox enviaPassword = (TextBox)Page.PreviousPage.FindControl("txbPass");
                TextBox enviaRepetir = (TextBox)Page.PreviousPage.FindControl("txbRepetir");

                lbNombre.Text = enviaNombre.Text;
                lbApellidos.Text = enviApellidos.Text;
                lbPassword.Text = enviaPassword.Text;
                lbRepetir.Text = enviaRepetir.Text;
            }
        }

    }
}