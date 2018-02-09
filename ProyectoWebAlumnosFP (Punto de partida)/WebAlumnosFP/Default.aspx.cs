using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicaNegocios;

namespace WebAlumnosFP
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            CargaCombo();

        }

        private void CargaCombo()
        {
            List<Grupo> listaGrupos = LNyAD.ListaGrupos();

            listaGrupos.Insert(0, new Grupo(0, "Todos los grupos", "todos"));
            ddlGrupos.DataSource = listaGrupos;
            ddlGrupos.DataValueField = "IDGrupo";
            ddlGrupos.DataTextField = "Nombre";

            ddlGrupos.DataBind();
         
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