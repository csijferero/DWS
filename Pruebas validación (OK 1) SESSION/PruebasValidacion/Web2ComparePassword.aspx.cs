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


            lbNombre.Text = (Session["Nombre"]).ToString();
            lbApellidos.Text = (Session["Apellidos"]).ToString();

        }

        protected void ibtnEnviar_Click(object sender, ImageClickEventArgs e)
        {
            Session["Contraseña"] = txbPass.Text;
            Session["RepContraseña"] = txbRepetir.Text;
            Response.Redirect("Web3RangeTelefono.aspx");
        }
    }
}