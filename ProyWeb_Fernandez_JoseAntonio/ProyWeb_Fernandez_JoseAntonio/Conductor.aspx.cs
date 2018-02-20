using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LNegocioyADatos;

namespace ProyWeb_Fernandez_JoseAntonio
{
    public partial class Conductor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dgv.DataSource = LNyAD.TablaConductores(); //Llenamos el DataGridView a partir de un DataTable

            dgv.DataBind();
        }

        protected void tsbConductor_Click(object sender, ImageClickEventArgs e)
        {
            dgv.DataSource = LNyAD.TablaConductores(); //Llenamos el DataGridView a partir de un DataTable

            dgv.DataBind();
        }

        protected void tsbTarifa_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Tarifa.aspx");
        }

        protected void tsbCliente_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Cliente.aspx");
        }

        protected void tsbCarrera_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Carrera.aspx");
        }
    }
}