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
                txbNombre.Text = (Session["Nombre"]).ToString();
                txbApellidos.Text = (Session["Apellidos"]).ToString();
                txbPassword.Text = (Session["Contraseña"]).ToString();
                txbRepetir.Text = (Session["RepContraseña"]).ToString();
                txbMovil.Text = (Session["Movil"]).ToString();
                txbTelefono.Text = (Session["Telefono"]).ToString();
                txbEmail.Text = (Session["Email"]).ToString();
                txbPoblacion.Text = (Session["Poblacion"]).ToString();
                txbCP.Text = (Session["Cp"]).ToString();

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