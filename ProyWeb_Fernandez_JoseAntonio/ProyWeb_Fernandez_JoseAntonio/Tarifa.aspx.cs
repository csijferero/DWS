using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LNegocioyADatos;

namespace ProyWeb_Fernandez_JoseAntonio
{
    public partial class Tarifa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tsbTarifa_Click(object sender, ImageClickEventArgs e)
        {
            dgv.DataSource = LNyAD.TablaTarifas(); //Llenamos el DataGridView a partir de un DataTable

            dgv.DataBind();
        }
    }
}