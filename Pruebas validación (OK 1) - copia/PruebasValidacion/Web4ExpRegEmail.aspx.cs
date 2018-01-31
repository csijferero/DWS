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
                lbNombre.Text = (Session["Nombre"]).ToString();
                lbApellidos.Text = (Session["Apellidos"]).ToString();
                lbPassword.Text = (Session["Contraseña"]).ToString();
                lbRepetir.Text = (Session["RepContraseña"]).ToString();
                lbMovil.Text = (Session["Movil"]).ToString();
                lbTelefono.Text = (Session["Telefono"]).ToString();
            }
        }

        protected void ibtnEnviar_Click(object sender, ImageClickEventArgs e)
        {
            Session["Email"] = txbEmail.Text;
            Response.Redirect("Web5CustomDomicilio.aspx");
        }
    }
}