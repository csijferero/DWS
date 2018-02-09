using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAlumnosFP
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargaCombo();

        }

        private void CargaCombo()
        {
         
        }


        private void CargaAlumnosGrupo()
        {

        }



        protected void btnAnyadir_Click(object sender, EventArgs e)
        {

            Response.Redirect("PaginaDetalleAlumno.aspx");

        }
    }
}