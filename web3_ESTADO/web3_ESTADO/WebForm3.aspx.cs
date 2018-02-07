using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web3_ESTADO
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lblDensidadVal.Text = Server.HtmlEncode(Request.Cookies["miCo"]["densidad"]);
                lblPesoVal.Text = Server.HtmlEncode(Request.Cookies["miCo"]["peso"]);
                lblVolVal.Text = Server.HtmlEncode(Request.Cookies["miCo"]["volumen"]);
                lblComienzo.Text = Application["horaInicio"].ToString();
                lblHoraSesion.Text = Session["usuario"].ToString();
                lblTiempo.Text = ((DateTime)(Session["usuario"]) - (DateTime)(Application["horaInicio"])).ToString();
            }
        }
    }
}