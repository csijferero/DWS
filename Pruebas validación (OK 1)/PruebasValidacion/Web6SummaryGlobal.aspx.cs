using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebasValidacion
{
    public partial class WebFormGlobal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Label enviaNombre = (Label)Page.PreviousPage.FindControl("lbNombre");
                Label enviApellidos = (Label)Page.PreviousPage.FindControl("lbApellidos");
                Label enviaPassword = (Label)Page.PreviousPage.FindControl("lbPassword");
                Label enviaRepetir = (Label)Page.PreviousPage.FindControl("lbRepetir");
                Label enviaMovil = (Label)Page.PreviousPage.FindControl("lbMovil");
                Label enviaTelefono = (Label)Page.PreviousPage.FindControl("lbTelefono");
                Label enviaEmail = (Label)Page.PreviousPage.FindControl("lbEmail");
                TextBox enviaPoblacion = (TextBox)Page.PreviousPage.FindControl("txbPoblacion");
                TextBox enviaCP = (TextBox)Page.PreviousPage.FindControl("txbCP");




                txbNombre.Text = enviaNombre.Text;
                txbApellidos.Text = enviApellidos.Text;
                txbPassword.Text = enviaPassword.Text;
                txbRepetir.Text = enviaRepetir.Text;
                txbMovil.Text = enviaMovil.Text;
                txbTelefono.Text = enviaTelefono.Text;
                txbEmail.Text = enviaEmail.Text;
                txbPoblacion.Text = enviaPoblacion.Text;
                txbCP.Text = enviaCP.Text;

                txbPassword.Attributes["type"] = "password";
                txbRepetir.Attributes["type"] = "password";

            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            int cp;

            try
            {
                cp = Convert.ToInt32(txbCP.Text);
                if (cp >= 41000 && cp <= 41999)
                    args.IsValid = true;
                else
                    args.IsValid = false;
            }
            catch
            {
                args.IsValid = false;
            }
        }
    }
}