using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LNegocioyADatos;

namespace InterfazUsuario
{
    public partial class RegistroUsuario : Form
    {
        Usuarios usu;
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        bool cambiadoUser = false;
        bool cambiadoPass = false;
        bool cambiadoConfirm = false;

        #region Placeholder
        private void textNewUser_Enter(object sender, EventArgs e)
        {
            if (txbNewUser.Text == "Usuario" && cambiadoUser == false)
            {
                txbNewUser.ForeColor = Color.Black;
                txbNewUser.Text = "";
                cambiadoUser = true;
            }
        }

        private void textNewUser_Leave(object sender, EventArgs e)
        {
            if (txbNewUser.Text == "")
            {
                txbNewUser.Text = "Usuario";
                txbNewUser.ForeColor = Color.Gray;
                cambiadoUser = false;
            }
        }

        private void txbNewPass_Leave(object sender, EventArgs e)
        {
            if (txbNewPass.Text == "")
            {
                txbNewPass.UseSystemPasswordChar = false;
                txbNewPass.Text = "Contraseña";
                txbNewPass.ForeColor = Color.Gray;
                cambiadoPass = false;
            }
        }

        private void txbNewPass_Enter(object sender, EventArgs e)
        {
            if (txbNewPass.Text == "Contraseña" && cambiadoPass == false)
            {
                txbNewPass.ForeColor = Color.Black;
                txbNewPass.Text = "";
                txbNewPass.UseSystemPasswordChar = true;
                cambiadoPass = true;
            }
        }

        private void txbConfirmNewPass_Leave(object sender, EventArgs e)
        {
            if (txbConfirmNewPass.Text == "")
            {
                txbConfirmNewPass.UseSystemPasswordChar = false;
                txbConfirmNewPass.Text = "Confirmar Contraseña";
                txbConfirmNewPass.ForeColor = Color.Gray;
                cambiadoConfirm = false;
            }
        }

        private void txbConfirmNewPass_Enter(object sender, EventArgs e)
        {
            if (txbConfirmNewPass.Text == "Confirmar Contraseña" && cambiadoConfirm == false)
            {
                txbConfirmNewPass.ForeColor = Color.Black;
                txbConfirmNewPass.Text = "";
                txbConfirmNewPass.UseSystemPasswordChar = true;
                cambiadoConfirm = true;
            }
        }
        #endregion

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string texto = String.Empty;

            if (txbNewUser.ForeColor == Color.Gray || txbNewUser.Text == String.Empty)
            {
                texto = "El campo nombre no puede estar vacio\n";
                errorProvider1.SetError(txbNewUser, "Campo Vacio");
                txbConfirmNewPass.Text = String.Empty;
                txbNewPass.Text = String.Empty;
                txbNewPass_Leave(null, null);
                txbConfirmNewPass_Leave(null, null);
            }
            if (txbNewPass.ForeColor == Color.Gray || txbNewPass.Text == String.Empty)
            {
                texto += "El campo clave no puede estar vacio\n";
                errorProvider1.SetError(txbNewPass, "Campo Vacio");
                txbConfirmNewPass.Text = String.Empty;
                txbNewPass.Text = String.Empty;
                txbNewPass_Leave(null, null);
                txbConfirmNewPass_Leave(null, null);
            }
            if (txbConfirmNewPass.ForeColor == Color.Gray || txbConfirmNewPass.Text == String.Empty)
            {
                texto += "El campo Confirmar Clave no puede estar vacio";
                errorProvider1.SetError(txbConfirmNewPass, "Campo Vacio");
                txbConfirmNewPass.Text = String.Empty;
                txbNewPass.Text = String.Empty;
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
                txbNewPass_Leave(null, null);
                txbConfirmNewPass_Leave(null, null);
                return;
            }
            usu = LNyAD.buscaRegistro(txbNewUser.Text);
            if (usu != null)
            {
                errorProvider1.SetError(txbNewUser, "Usuario Repetido");
                MessageBox.Show("Ya existe un usuario con el mismo nombre registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbConfirmNewPass.Text = String.Empty;
                txbNewPass.Text = String.Empty;
                txbNewPass_Leave(null, null);
                txbConfirmNewPass_Leave(null, null);
            }
            else if (chbTerminos.Checked)
            {
                LNyAD.agregarUsuario(txbNewUser.Text, txbNewPass.Text);
                errorProvider1.Clear();
                MessageBox.Show("El Usuario ha sido registrado con éxito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe aceptar los Términos y Condiciones", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {
            btnRegistro.Select();
        }

        private void txbKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnRegistro_Click(null, null);
            }
        }
    }
}
