using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebasValidacion
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lblSaludo.Text = "Usuario " + ((TextBox)Page.PreviousPage.FindControl("txbNombre")).Text + " " + ((TextBox)Page.PreviousPage.FindControl("txbApell")).Text;
            }
        }
    }
}