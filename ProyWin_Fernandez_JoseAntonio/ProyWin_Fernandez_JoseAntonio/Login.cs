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
    public partial class Login : Form
    {
        Usuarios usu;
        public Login()
        {
            InitializeComponent();
        }

        bool cambiadoUser = false;
        bool cambiadoPass = false;

        #region Placeholder
        private void textUser_Enter(object sender, EventArgs e)
        {
            if (txbUser.Text == "Usuario" && cambiadoUser == false)
            {
                txbUser.ForeColor = Color.Black;
                txbUser.Text = "";
                cambiadoUser = true;
            }
        }

        private void textUser_Leave(object sender, EventArgs e)
        {
            if (txbUser.Text == "")
            {
                txbUser.Text = "Usuario";
                txbUser.ForeColor = Color.Gray;
                cambiadoUser = false;
            }
        }

        private void txbPass_Leave(object sender, EventArgs e)
        {
            if (txbPass.Text == "")
            {
                txbPass.UseSystemPasswordChar = false;
                txbPass.Text = "Contraseña";
                txbPass.ForeColor = Color.Gray;
                cambiadoPass = false;
            }
        }

        private void txbPass_Enter(object sender, EventArgs e)
        {
            if (txbPass.Text == "Contraseña" && cambiadoPass == false)
            {
                txbPass.ForeColor = Color.Black;
                txbPass.Text = "";
                txbPass.UseSystemPasswordChar = true;
                cambiadoPass = true;
            }
        }
        #endregion

        private void Login_Load(object sender, EventArgs e)
        {
            btnAcceder.Select();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string texto = String.Empty;

            if (txbUser.ForeColor == Color.Gray || txbUser.Text == String.Empty)
            {
                texto = "El campo nombre no puede estar vacio\n";
            }
            if (txbPass.ForeColor == Color.Gray || txbPass.Text == String.Empty)
            {
                texto += "El campo clave no puede estar vacio";
            }
            if (texto != String.Empty)
            {
                MessageBox.Show(texto, "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            usu = LNyAD.buscaUsuario(txbUser.Text, txbPass.Text);
            if (usu == null)
            {
                errorProvider1.SetError(btnAcceder, "Login Incorrecto");
                MessageBox.Show("No se ha encontrado ningun registro con dicha identificacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                errorProvider1.Clear();
                IUDatos iuDatos = new IUDatos();
                iuDatos.ShowDialog();
            }
        }

        private void txbKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAcceder_Click(null, null);
            }

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            RegistroUsuario regUser = new RegistroUsuario();
            regUser.ShowDialog();
        }
    }
}