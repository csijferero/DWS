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
            lblDensidadVal.Text = Request.Params.Get("txbDensidad");
            lblPesoVal.Text = Request.Params.Get("txbPeso");
            lblVolVal.Text = Request.Params.Get("txbVol");
        }
    }
}