using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LNegocioyADatos;


namespace ProyWeb_Fernandez_JoseAntonio
{
    public partial class Login : System.Web.UI.Page
    {
        Usuarios usu;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Session["usuario"] = null;
            }

            //if (!IsPostBack)
            //{
            //    loginVal.IsValid = true;
            //    loginVal2.IsValid = true;
            //    passVal.IsValid = true;
            //    passVal2.IsValid = true;
            //    actiVal.IsValid = true;
            //    txbPass.Text = String.Empty;
            //    txbUser.Text = String.Empty;
            //}
        }

        protected void btnAcceder_Click(object sender, EventArgs e)
        {
            if (LNyAD.BuscaLogin(txbUser.Text) == null) //Si NO hay un usuario con dicho nombre doy error
            {
                loginVal2.IsValid = false;
                txbPass.Text = String.Empty;
                return;
            }
            usu = LNyAD.BuscaUsuario(txbUser.Text, Encriptacion.Encriptar(txbPass.Text)); // Lo declaro aqui porque lo usare varias veces
            if (usu != null) //Si el Usuario y la Contraseña son correctos accedo
            {
                if (usu.AccesoUsuario == 0)
                    actiVal.IsValid = false;
                else
                {
                    txbPass.Text = String.Empty;
                    txbUser.Text = String.Empty;
                    Session["usuario"] = usu;
                    Response.Redirect("Tarifa.aspx");
                }
            }
            else //Si la contraseña es erronea doy error
            {
                passVal2.IsValid = false;
                txbPass.Text = String.Empty;
            }
        }

        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro.aspx");
        }
    }
}