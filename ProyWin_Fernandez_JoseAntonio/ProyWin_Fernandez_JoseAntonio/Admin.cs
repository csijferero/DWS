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
    public partial class Admin : Form
    {
        Usuarios usu;
        Usuarios usuarioDentro;

        public Usuarios UsuarioDentro
        {
            get
            {
                return usuarioDentro;
            }

            set
            {
                usuarioDentro = value;
            }
        }

        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            if (usuarioDentro.AccesoUsuario != 1) //Si NO es administrador
            {
                cmbAcceso.Enabled = false;
                btnReset.Visible = false;
                txbClave.Visible = false;
                labelContraseña.Visible = false;
            }

            cargarDGV();

            //Cargo el comboBox
            cmbAcceso.Items.Insert(0, "[0] Deshabilitado");
            cmbAcceso.Items.Insert(1, "[1] Administrador");
            cmbAcceso.Items.Insert(2, "[2] User");

            dgv_CellClick(null, null); //Aplico el metodo para rellenar los campos
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            usu = LNyAD.obtenerUsuario(Convert.ToInt32(dgv.Rows[dgv.CurrentRow.Index].Cells[0].Value.ToString())); //Obtengo el usuario seleccionado
            //Relleno los campos de nuevo con los de la fila seleccionada
            txbID.Text = usu.IdUsuario.ToString();
            txbNombre.Text = usu.NombreUsuario;
            txbAlias.Text = usu.AliasUsuario;
            txbLogin.Text = usu.LoginUsuario;
            txbClave.Text = Encriptacion.DesEncriptar(usu.ClaveUsuario);
            cmbAcceso.SelectedIndex = Convert.ToInt32(usu.AccesoUsuario);

            if (usu.IdUsuario == usuarioDentro.IdUsuario) //Si el usuario a seleccionado su usuario, podrá cambiar su contraseña
            {
                labelContraseña.Visible = true;
                txbClave.Visible = true;
            }
            else
            {
                labelContraseña.Visible = false;
                txbClave.Visible = false;
            }
        }
        private bool HayErrorEnFormulario()
        {
            errorProvider1.Clear();

            //int num;
            string text = "";
            bool error = false;
            if (Convert.ToInt32(txbID.Text) == usu.IdUsuario && txbNombre.Text == usu.NombreUsuario && txbAlias.Text == usu.AliasUsuario
                && txbLogin.Text == usu.LoginUsuario && cmbAcceso.SelectedIndex == usu.AccesoUsuario && Encriptacion.Encriptar(txbClave.Text) == usu.ClaveUsuario) //Si todos los campos son iguales ERROR
            {
                text += "No se ha realizado ningun cambio";
                error = true;
            }
            //if (txbID.Text == String.Empty) //Campo ID Vacio ERROR
            //{
            //    text += "Campo ID vacio";
            //    error = true;
            //    errorProvider1.SetError(txbID, "Vacio");
            //}
            //else if (!Int32.TryParse(txbID.Text, out num)) //Campo ID con letras ERROR
            //{
            //    text += "Debe introducir un numero en el campo ID";
            //    error = true;
            //    errorProvider1.SetError(txbID, "Formato Incorrecto");
            //}
            //else if (LNyAD.obtenerUsuario(Convert.ToInt32(txbID.Text)) != null && Convert.ToInt32(txbID.Text) != usu.IdUsuario) //Existe un ID igual y es diferente al que tenia anteriormente el usuario ERROR
            //{
            //    text += "El ID ya existe";
            //    error = true;
            //    errorProvider1.SetError(txbID, "Repetido");
            //}
            if (txbNombre.Text == String.Empty)
            {
                text += "Campo Nombre vacio";
                error = true;
                errorProvider1.SetError(txbNombre, "Vacio");
            }
            if (txbAlias.Text == String.Empty) //Campo Alias vacio ERROR
            {
                text += "Campo Alias vacio";
                error = true;
                errorProvider1.SetError(txbAlias, "Vacio");
            }
            else if (txbAlias.Text.Length != 4)
            {
                text += "El Alias debe tener 4 caracteres";
                error = true;
                errorProvider1.SetError(txbAlias, "Formato");
            }
            else if (LNyAD.buscaAlias(txbAlias.Text) != null && txbAlias.Text != usu.AliasUsuario) //Existe un alias igual y es diferente al que tenia anteriormente el usuario ERROR
            {
                text += "El alias ya existe";
                error = true;
                errorProvider1.SetError(txbAlias, "Repetido");
            }
            if (txbLogin.Text == String.Empty) //Campo Login vacio ERROR
            {
                text += "Campo Login vacio";
                error = true;
                errorProvider1.SetError(txbLogin, "Vacio");
            }
            else if (LNyAD.buscaLogin(txbLogin.Text) != null && txbLogin.Text != usu.LoginUsuario) //Existe un login igual y es diferente al que tenia anteriormente el usuario ERROR
            {
                text += "El login ya existe";
                error = true;
                errorProvider1.SetError(txbLogin, "Repetido");
            }
            if (cmbAcceso.Text == String.Empty) //Campo Acceso vacio ERROR
            {
                text += "No se ha seleccionado ningun nivel de acceso";
                error = true;
                errorProvider1.SetError(cmbAcceso, "Vacio");
            }
            if (error)
                MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return error;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (HayErrorEnFormulario())
                return;

            //Actualizo el usuario
            usu.IdUsuario = Convert.ToInt32(txbID.Text);
            usu.NombreUsuario = txbNombre.Text;
            usu.AliasUsuario = txbAlias.Text;
            usu.LoginUsuario = txbLogin.Text;
            usu.AccesoUsuario = Convert.ToInt32(cmbAcceso.SelectedIndex);
            usu.ClaveUsuario = Encriptacion.Encriptar(txbClave.Text);
            LNyAD.editarUsuario(usu);

            MessageBox.Show("Operación realizada", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cargarDGV();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea resetear la contraseña de este usuario a [1234]?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                usu.ClaveUsuario = Encriptacion.Encriptar("1234");
                LNyAD.editarUsuario(usu);
                MessageBox.Show("Operación realizada", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDGV();
            }
        }

        private void cargarDGV()
        {
            if (usuarioDentro.AccesoUsuario == 1) //Si el usuario es administrador...
                dgv.DataSource = LNyAD.tablaUsuarios(); //Cargo el DGV con todos los usuarios
            else //Si es un usuario normal...
                dgv.DataSource = LNyAD.tablaUsuarios(usuarioDentro.IdUsuario); //Cargo el DGV solo con su usuario
        }
    }
}
