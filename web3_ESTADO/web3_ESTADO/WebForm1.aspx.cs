﻿using System;
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
            if (ViewState["hora"] == null)
            {
                ViewState.Add("hora", DateTime.Now.ToString()); //Estado Vista
                Application["horaInicio"] = DateTime.Now; //Estado aplicacion
            }
            else
            {
                ViewState["hora"] = DateTime.Now.ToString(); //Estado Vista
                Session["usuario"] = DateTime.Now; //Estado Session
            }

            if (lblHora.Text != null)
            {
                lblHoraAnterior.Text = lblHora.Text;
            }
            lblHora.Text = ViewState["hora"].ToString();


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Cookies["miCo"]["densidad"] = txbDensidad.Text; //Cookies
            Response.Redirect(String.Format("WebForm2.aspx?txbPeso={0}&txbVol={1}&urlAnterior={2}", txbPeso.Text, txbVolumen.Text, lblDir.Text));

        }
    }
}