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
            if (usuarioDentro.AccesoUsuario != 1) //Si NO es administrador NO permito cambiar acceso, resetear clave ni borrar user
            {
                cmbAcceso.Enabled = false;
                btnReset.Visible = false;
                dgv.Columns[0].Visible = false;
            }

            CargarDGV(); //Cargo el DGV

            //Cargo el comboBox
            cmbAcceso.Items.Insert(0, "[0] Deshabilitado");
            cmbAcceso.Items.Insert(1, "[1] Administrador");
            cmbAcceso.Items.Insert(2, "[2] User");

            dgv.Columns[0].DisplayIndex = dgv.Columns.Count - 1; //Coloco el boton de borrar al final

            CargaCelda(); //Cargo los datos de la fila

        }

        private void CargaCelda()
        {
            usu = LNyAD.ObtenerUsuario(Convert.ToInt32(dgv.Rows[dgv.CurrentRow.Index].Cells[1].Value.ToString())); //Obtengo el usuario seleccionado
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

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            errorProvider1.Clear();
            CargaCelda(); //Cargo los datos de la fila

            //Si pulso borrar...
            if (e.RowIndex >= 0 && dgv.Columns[dgv.CurrentCell.ColumnIndex].HeaderText == "Del"
                && (MessageBox.Show("¿Está seguro de que desea borrar el registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                if (LNyAD.BuscaAdmin().Count == 1 && usu.AccesoUsuario == 1) //Y quiero borrar al unico admin ERROR
                {
                    MessageBox.Show("No se puede borrar al unico administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    LNyAD.BorarUsuario(usu.IdUsuario);
                    CargarDGV();
                    CargaCelda();
                }
            }
        }
        private bool HayErrorEnFormulario()
        {
            errorProvider1.Clear();

            string text = "";
            bool error = false;
            if (Convert.ToInt32(txbID.Text) == usu.IdUsuario && txbNombre.Text == usu.NombreUsuario && txbAlias.Text == usu.AliasUsuario
                && txbLogin.Text == usu.LoginUsuario && cmbAcceso.SelectedIndex == usu.AccesoUsuario && Encriptacion.Encriptar(txbClave.Text) == usu.ClaveUsuario) //Si todos los campos son iguales ERROR
            {
                text += "No se ha realizado ningun cambio";
                error = true;
            }
            if (txbNombre.Text == String.Empty) //Campo Nombre vacio ERROR
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
            else if (txbAlias.Text.Length != 4) //Campo Alias menos de 4 caracteres
            {
                text += "El Alias debe tener 4 caracteres";
                error = true;
                errorProvider1.SetError(txbAlias, "Formato");
            }
            else if (LNyAD.BuscaAlias(txbAlias.Text) != null && txbAlias.Text != usu.AliasUsuario) //Existe un alias igual y es diferente al que tenia anteriormente el usuario ERROR
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
            else if (LNyAD.BuscaLogin(txbLogin.Text) != null && txbLogin.Text != usu.LoginUsuario) //Existe un login igual y es diferente al que tenia anteriormente el usuario ERROR
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
            else if (LNyAD.BuscaAdmin().Count == 1 && usu.AccesoUsuario == 1 && cmbAcceso.SelectedIndex != 1) //Intento quitar el unico administrador ERROR
            {
                text += "Debe haber un administrador como minimo";
                error = true;
                errorProvider1.SetError(cmbAcceso, "Agregue otro Admin");
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
            usu.AliasUsuario = txbAlias.Text.ToUpper();
            usu.LoginUsuario = txbLogin.Text;
            usu.AccesoUsuario = Convert.ToInt32(cmbAcceso.SelectedIndex);
            usu.ClaveUsuario = Encriptacion.Encriptar(txbClave.Text);
            LNyAD.EditarUsuario(usu);

            MessageBox.Show("Operación realizada", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Cargo el DGV y selecciono la fila editada
            int fila = dgv.CurrentRow.Index;
            CargarDGV();
            dgv.CurrentCell = dgv.Rows[fila].Cells[2];
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea resetear la contraseña de este usuario a [1234]?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                usu.ClaveUsuario = Encriptacion.Encriptar("1234");
                LNyAD.EditarUsuario(usu);
                MessageBox.Show("Operación realizada", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Cargo el DGV y selecciono la fila editada
                int fila = dgv.CurrentRow.Index;
                CargarDGV();
                dgv.CurrentCell = dgv.Rows[fila].Cells[2];
                CargaCelda();
            }
        }

        private void CargarDGV()
        {
            if (usuarioDentro.AccesoUsuario == 1) //Si el usuario es administrador...
                dgv.DataSource = LNyAD.TablaUsuarios(); //Cargo el DGV con todos los usuarios
            else //Si es un usuario normal...
                dgv.DataSource = LNyAD.TablaUsuarios(usuarioDentro.IdUsuario); //Cargo el DGV solo con su usuario
        }

        private void txbKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnGuardar_Click(null, null);
            }
        }
    }
}
