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
            if(Page.IsPostBack)
                //txbSeguimiento.Text += "\n---------> Hago postBack y Estoy en el Load";
                lbBienvenido.Text += "\n---------> Hago postBack y Estoy en el Load";
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
                txbSeguimiento.Text += "\n---------> Estoy en el btnEnviar_Click";
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            int intEdad;
            txbSeguimiento.Text += "\n-----------> Estoy en el Custom del servidor";
            try
            {
                intEdad = Convert.ToInt32(txbRepEdad.Text);
                if (intEdad < 18 || intEdad>75)
                    args.IsValid = false;
                else
                    args.IsValid = true;
            }
            catch
            { 
                args.IsValid = false; 
            }

        }
    }
}