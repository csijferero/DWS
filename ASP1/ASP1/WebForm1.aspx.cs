using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (chbPagina.Checked)
                Response.Redirect("http://altair.edu.es");
        }

        protected void btnSaludar_Click(object sender, EventArgs e)
        {
            if (rbMay.Checked)
            {
                label.Text = "HOLA " + txbNombre.Text.ToUpper();
            }
            else if (rbMin.Checked)
            {
                label.Text = "hola " + txbNombre.Text.ToLower();
            }
            else
                label.Text = "Hola " + txbNombre.Text;
        }

        protected void chbVuelta_CheckedChanged(object sender, EventArgs e)
        {
            if (chbVuelta.Checked)
                txbNombre.Visible = false;
            else
                txbNombre.Visible = true;
        }

        protected void btn_Click(object sender, EventArgs e)
        {

        }
    }
}