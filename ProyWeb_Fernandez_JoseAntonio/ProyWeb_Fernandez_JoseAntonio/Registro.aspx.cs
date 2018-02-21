using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LNegocioyADatos;

namespace ProyWeb_Fernandez_JoseAntonio
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Session["usuario"] = null;
            }
        }

        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            if (txbNewPass.Text != txbConfirmNewPass.Text)
            {
                txbConfirmNewPass.Text = String.Empty;
                txbNewPass.Text = String.Empty;
                return;
            }
            if (LNyAD.BuscaLogin(txbNewUser.Text) != null)
            {
                txbConfirmNewPass.Text = String.Empty;
                txbNewPass.Text = String.Empty;
                loginValEx.IsValid = false;
            }
            else if (LNyAD.BuscaAlias(txbAlias.Text) != null)
            {
                txbConfirmNewPass.Text = String.Empty;
                txbNewPass.Text = String.Empty;
                aliasValEx.IsValid = false;
            }
            else if (chbTerminos.Checked)
            {
                LNyAD.AgregarUsuario(txbNombre.Text, txbAlias.Text.ToUpper(), txbNewUser.Text, Encriptacion.Encriptar(txbNewPass.Text));
                Response.Redirect("Login.aspx");
            }
            else
            {
                confVal.IsValid = false;
            }
        }
    }
}