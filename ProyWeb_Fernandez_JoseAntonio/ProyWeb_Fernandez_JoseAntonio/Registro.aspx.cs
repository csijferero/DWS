using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyWeb_Fernandez_JoseAntonio
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            string texto = String.Empty;

            if (txbNewUser.ForeColor == Color.Gray || txbNewUser.Text == String.Empty)
            {
                texto = "El campo usuario no puede estar vacio\n";
                errorProvider1.SetError(txbNewUser, "Campo Vacio");
                txbConfirmNewPass.Text = String.Empty;
                txbNewPass.Text = String.Empty;
                btnRegistro.Focus();
                txbNewPass_Leave(null, null);
                txbConfirmNewPass_Leave(null, null);
            }
            if (txbAlias.ForeColor == Color.Gray || txbAlias.Text == String.Empty)
            {
                texto += "El campo alias no puede estar vacio\n";
                errorProvider1.SetError(txbAlias, "Campo Vacio");
                txbConfirmNewPass.Text = String.Empty;
                txbNewPass.Text = String.Empty;
                btnRegistro.Focus();
                txbNewPass_Leave(null, null);
                txbConfirmNewPass_Leave(null, null);
            }
            if (txbNombre.ForeColor == Color.Gray || txbNombre.Text == String.Empty)
            {
                texto += "El campo nombre no puede estar vacio\n";
                errorProvider1.SetError(txbNombre, "Campo Vacio");
                txbConfirmNewPass.Text = String.Empty;
                txbNewPass.Text = String.Empty;
                btnRegistro.Focus();
                txbNewPass_Leave(null, null);
                txbConfirmNewPass_Leave(null, null);
            }
            if (txbNewPass.ForeColor == Color.Gray || txbNewPass.Text == String.Empty)
            {
                texto += "El campo clave no puede estar vacio\n";
                errorProvider1.SetError(txbNewPass, "Campo Vacio");
                txbConfirmNewPass.Text = String.Empty;
                txbNewPass.Text = String.Empty;
                btnRegistro.Focus();
                txbNewPass_Leave(null, null);
                txbConfirmNewPass_Leave(null, null);
            }
            if (txbConfirmNewPass.ForeColor == Color.Gray || txbConfirmNewPass.Text == String.Empty)
            {
                texto += "El campo Confirmar Clave no puede estar vacio";
                errorProvider1.SetError(txbConfirmNewPass, "Campo Vacio");
                txbConfirmNewPass.Text = String.Empty;
                txbNewPass.Text = String.Empty;
                btnRegistro.Focus();
                txbNewPass_Leave(null, null);
                txbConfirmNewPass_Leave(null, null);
            }
            if (texto != String.Empty)
            {
                MessageBox.Show(texto, "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txbNewPass.Text != txbConfirmNewPass.Text)
            {
                MessageBox.Show("La contraseña de confirmacion no coincide", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProvider1.SetError(txbConfirmNewPass, "Campo Diferente");
                txbConfirmNewPass.Text = String.Empty;
                txbNewPass.Text = String.Empty;
                btnRegistro.Focus();
                txbNewPass_Leave(null, null);
                txbConfirmNewPass_Leave(null, null);
                return;
            }
            if (LNyAD.BuscaLogin(txbNewUser.Text) != null)
            {
                errorProvider1.SetError(txbNewUser, "Usuario Repetido");
                MessageBox.Show("Ya existe un usuario con el mismo nombre registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbConfirmNewPass.Text = String.Empty;
                txbNewPass.Text = String.Empty;
                btnRegistro.Focus();
                txbNewPass_Leave(null, null);
                txbConfirmNewPass_Leave(null, null);
            }
            else if (LNyAD.BuscaAlias(txbAlias.Text) != null)
            {
                errorProvider1.SetError(txbAlias, "Alias Repetido");
                MessageBox.Show("Ya existe un usuario con el mismo alias registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbConfirmNewPass.Text = String.Empty;
                txbNewPass.Text = String.Empty;
                btnRegistro.Focus();
                txbNewPass_Leave(null, null);
                txbConfirmNewPass_Leave(null, null);
            }
            else if (chbTerminos.Checked)
            {
                LNyAD.AgregarUsuario(txbNombre.Text, txbAlias.Text.ToUpper(), txbNewUser.Text, Encriptacion.Encriptar(txbNewPass.Text));
                errorProvider1.Clear();
                MessageBox.Show("El Usuario ha sido registrado con éxito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe aceptar los Términos y Condiciones", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}