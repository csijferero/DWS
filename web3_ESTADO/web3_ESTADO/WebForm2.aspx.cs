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
                lblURL.Text = Request.Params.Get("urlAnterior");
                txbDensidad.Text = Server.HtmlEncode(Request.Cookies["miCo"]["densidad"]);
                txbPeso.Text = Request.Params.Get("txbPeso");
                txbVolumen.Text = Request.Params.Get("txbVol");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect(String.Format("WebForm3.aspx?txbPeso={0}&txbVol={1}&txbDensidad={2}", txbPeso.Text, txbVolumen.Text, txbDensidad.Text));

        }
    }
}