using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web3_ESTADO
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lblURL.Text = Server.HtmlEncode(Request.Cookies["miCo"]["url"]);
                txbDensidad.Text = Server.HtmlEncode(Request.Cookies["miCo"]["densidad"]);
                txbPeso.Text = Server.HtmlEncode(Request.Cookies["miCo"]["peso"]);
                txbVolumen.Text = Server.HtmlEncode(Request.Cookies["miCo"]["volumen"]);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm3.aspx");
            Response.Cookies["miCo"]["densidad"] = txbDensidad.Text; //Cookies
            Response.Cookies["miCo"]["peso"] = txbPeso.Text; //Cookies
            Response.Cookies["miCo"]["volumen"] = txbVolumen.Text; //Cookies
        }
    }
}