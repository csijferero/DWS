using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web3_ESTADO
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                Application["horaInicio"] = DateTime.Now; //Estado aplicacion
                Button1_Click(null, null);
            }



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Cookies["miCo"]["densidad"] = txbDensidad.Text; //Cookies
            Response.Cookies["miCo"]["peso"] = txbPeso.Text; //Cookies
            Response.Cookies["miCo"]["volumen"] = txbVolumen.Text; //Cookies
            Response.Cookies["miCo"]["url"] = lblDir.Text; //Cookies
            Response.Redirect("WebForm2.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ViewState["hora"] == null)
            {
                ViewState.Add("hora", DateTime.Now.ToString()); //Estado Vista
            }
            else
            {
                ViewState["hora"] = DateTime.Now.ToString(); //Estado Vista
            }
            Session["usuario"] = DateTime.Now; //Estado Session



            if (lblHora.Text != null)
            {
                lblHoraAnterior.Text = lblHora.Text;
            }
            lblHora.Text = ViewState["hora"].ToString();
        }
    }
}