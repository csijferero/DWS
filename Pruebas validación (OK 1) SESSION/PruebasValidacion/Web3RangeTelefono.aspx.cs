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
                lbNombre.Text = (Session["Nombre"]).ToString();
                lbApellidos.Text = (Session["Apellidos"]).ToString();
                lbPassword.Text = (Session["Contraseña"]).ToString();
                lbRepetir.Text = (Session["RepContraseña"]).ToString();
            }
        }

        protected void ibtnEnviar_Click(object sender, ImageClickEventArgs e)
        {
            Session["Movil"] = txbMovil.Text;
            Session["Telefono"] = txbTelefono.Text;
            Response.Redirect("Web4ExpRegEmail.aspx");
        }
    }
}