using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebasValidacion
{
    public partial class WebFormEmail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Label enviaNombre = (Label)Page.PreviousPage.FindControl("lbNombre");
                Label enviApellidos = (Label)Page.PreviousPage.FindControl("lbApellidos");
                Label enviaPassword = (Label)Page.PreviousPage.FindControl("lbPassword");
                Label enviaRepetir = (Label)Page.PreviousPage.FindControl("lbRepetir");
                TextBox enviaMovil = (TextBox)Page.PreviousPage.FindControl("txbMovil");
                TextBox enviaTelefono = (TextBox)Page.PreviousPage.FindControl("txbTelefono");




                lbNombre.Text = enviaNombre.Text;
                lbApellidos.Text = enviApellidos.Text;
                lbPassword.Text = enviaPassword.Text;
                lbRepetir.Text = enviaRepetir.Text;
                lbMovil.Text = enviaMovil.Text;
                lbTelefono.Text = enviaTelefono.Text;
            }
        }

    }
}