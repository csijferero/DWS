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
                lbNombre.Text = (Session["Nombre"]).ToString();
                lbApellidos.Text = (Session["Apellidos"]).ToString();
                lbPassword.Text = (Session["Contraseña"]).ToString();
                lbRepetir.Text = (Session["RepContraseña"]).ToString();
                lbMovil.Text = (Session["Movil"]).ToString();
                lbTelefono.Text = (Session["Telefono"]).ToString();
                lbEmail.Text = (Session["Email"]).ToString();
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

        protected void ibtnEnviar_Click(object sender, ImageClickEventArgs e)
        {
            Session["Poblacion"] = txbPoblacion.Text;
            Session["CP"] = txbCP.Text;
            Response.Redirect("Web6SummaryGlobal.aspx");
        }
    }
}