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
            errorProvider1.Clear();
            string texto = String.Empty;

            if (txbUser.ForeColor == Color.Gray || txbUser.Text == String.Empty) //Usuario Vacio
            {
                texto = "El campo nombre no puede estar vacio\n";
                errorProvider1.SetError(txbUser, "Campo Vacio");
                txbPass.Text = String.Empty;
                btnAcceder.Focus();
                txbPass_Leave(null, null);
            }
            if (txbPass.ForeColor == Color.Gray || txbPass.Text == String.Empty) //Clave Vacia
            {
                texto += "El campo clave no puede estar vacio";
                errorProvider1.SetError(txbPass, "Campo Vacio");
            }
            if (texto != String.Empty)
            {
                MessageBox.Show(texto, "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (LNyAD.BuscaLogin(txbUser.Text) == null) //Si NO hay un usuario con dicho nombre doy error
            {
                errorProvider1.SetError(txbUser, "Usuario Incorrecto");
                MessageBox.Show("No se ha encontrado ningun registro con dicho usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbPass.Text = String.Empty;
                btnAcceder.Focus();
                txbPass_Leave(null, null);
                return;
            }
            usu = LNyAD.BuscaUsuario(txbUser.Text, Encriptacion.Encriptar(txbPass.Text)); // Lo declaro aqui porque lo usare varias veces
            if (usu != null) //Si el Usuario y la Contraseña son correctos accedo
            {
                errorProvider1.Clear();
                if (usu.AccesoUsuario == 0)
                    MessageBox.Show("No puedes acceder a la aplicacion hasta que se de de alta tu cuenta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    txbPass.Text = String.Empty;
                    txbUser.Text = String.Empty;
                    btnAcceder.Focus();
                    txbPass_Leave(null, null);
                    textUser_Leave(null, null);
                    IUDatos iuDatos = new IUDatos();
                    iuDatos.Usu = usu; //Mando el usuario al siguiente formulario
                    iuDatos.ShowDialog();
                    iuDatos.Dispose();
                }
            }
            else //Si la contraseña es erronea doy error
            {
                errorProvider1.SetError(txbPass, "Clave incorrecta");
                MessageBox.Show("La clave de usuario no es valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbPass.Text = String.Empty;
                btnAcceder.Focus();
                txbPass_Leave(null, null);
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
            errorProvider1.Clear();
            txbPass.Text = String.Empty;
            txbUser.Text = String.Empty;
            txbPass_Leave(null, null);
            textUser_Leave(null, null);
            RegistroUsuario regUser = new RegistroUsuario();
            regUser.ShowDialog();
            regUser.Dispose();
        }
    }
}