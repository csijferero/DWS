using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebasValidacion
{
    public partial class WebFormDomicilio : System.Web.UI.Page
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
                TextBox enviaEmail = (TextBox)Page.PreviousPage.FindControl("txbEmail");




                lbNombre.Text = enviaNombre.Text;
                lbApellidos.Text = enviApellidos.Text;
                lbPassword.Text = enviaPassword.Text;
                lbRepetir.Text = enviaRepetir.Text;
                lbMovil.Text = enviaMovil.Text;
                lbTelefono.Text = enviaTelefono.Text;
                lbEmail.Text = enviaEmail.Text;
                

               
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