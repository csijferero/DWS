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
    public partial class IUDatos : Form
    {
        Usuarios usu;
        string textoCabecera;

        public Usuarios Usu
        {
            get
            {
                return usu;
            }

            set
            {
                usu = value;
            }
        }

        public IUDatos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (usu.AccesoUsuario != 1) //Si NO es administrador
            {
                btnAñadir.Enabled = false;
            }
            //List<Clientes> listaClientes = LNyAD.listaClientes(); //Rellenamos la lista desde la BD


        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Si pulso borrar...
            if (e.RowIndex >= 0 && dgv.Columns[dgv.CurrentCell.ColumnIndex].HeaderText == "Del"
                && (MessageBox.Show("¿Está seguro de que desea borrar el registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                int colum;

                if (usu.AccesoUsuario == 1)
                    colum = 1;
                else
                    colum = 0;

                if (dgv.Columns[colum].HeaderText == "idCliente") //Y quiero borrar un cliente
                {
                    LNyAD.BorarCliente(Convert.ToInt32(dgv.Rows[dgv.CurrentRow.Index].Cells[colum].Value.ToString()));
                    tsbCliente_Click(null, null);
                }
                else if (dgv.Columns[colum].HeaderText == "idConductor") //Y quiero borrar un conductor
                {
                    LNyAD.BorarConductor(Convert.ToInt32(dgv.Rows[dgv.CurrentRow.Index].Cells[colum].Value.ToString()));
                    tsbConductor_Click(null, null);
                }
                else if (dgv.Columns[colum].HeaderText == "idTarifa") //Y quiero borrar un conductor
                {
                    LNyAD.BorarTarifa(Convert.ToInt32(dgv.Rows[dgv.CurrentRow.Index].Cells[colum].Value.ToString()));
                    tsbTarifa_Click(null, null);
                }
                else if (dgv.Columns[colum].HeaderText == "idCarrera") //Y quiero borrar un conductor
                {
                    LNyAD.BorarCarrera(Convert.ToInt32(dgv.Rows[dgv.CurrentRow.Index].Cells[colum].Value.ToString()));
                    tsbCarrera_Click(null, null);
                }
            }
        }

        private void tsbCliente_Click(object sender, EventArgs e)
        {
            if (dgv.Columns[0].Visible == false && usu.AccesoUsuario == 1) //Si soy ADMIN y el Del esta invisible lo activo
                dgv.Columns[0].Visible = true;

            dgv.DataSource = LNyAD.TablaClientes(); //Llenamos el DataGridView a partir de un DataTable
            dgv.Columns["idCliente"].Visible = false; //Ocultamos los IDs
            dgv.Columns[2].HeaderText = "Nombre";
            dgv.Columns[3].HeaderText = "Apellidos";
            dgv.Columns[4].HeaderText = "Domicilio";
            dgv.Columns[5].HeaderText = "Email";
            dgv.Columns[6].HeaderText = "DNI";
            dgv.Columns[0].DisplayIndex = dgv.Columns.Count - 1;

            textoCabecera = "Usted está viendo: Clientes";
            lblBase.Text = textoCabecera;
        }

        private void tsbConductor_Click(object sender, EventArgs e)
        {
            if (dgv.Columns[0].Visible == false && usu.AccesoUsuario == 1) //Si soy ADMIN y el Del esta invisible lo activo
                dgv.Columns[0].Visible = true;

            dgv.DataSource = LNyAD.TablaConductores(); //Llenamos el DataGridView a partir de un DataTable
            dgv.Columns["idConductor"].Visible = false; //Ocultamos los IDs
            dgv.Columns[2].HeaderText = "Nombre";
            dgv.Columns[3].HeaderText = "Apellidos";
            dgv.Columns[4].HeaderText = "Domicilio";
            dgv.Columns[5].HeaderText = "Email";
            dgv.Columns[6].HeaderText = "DNI";
            dgv.Columns[7].HeaderText = "Licencia";
            dgv.Columns[8].HeaderText = "Matrícula";
            dgv.Columns[0].DisplayIndex = dgv.Columns.Count - 1;

            textoCabecera = "Usted está viendo: Conductores";
            lblBase.Text = textoCabecera;
        }

        private void tsbTarifa_Click(object sender, EventArgs e)
        {
            if (dgv.Columns[0].Visible == false && usu.AccesoUsuario == 1) //Si soy ADMIN y el Del esta invisible lo activo
                dgv.Columns[0].Visible = true;

            dgv.DataSource = LNyAD.TablaTarifas(); //Llenamos el DataGridView a partir de un DataTable
            dgv.Columns["idTarifa"].Visible = false; //Ocultamos los IDs
            dgv.Columns[2].HeaderText = "Tarifa";
            dgv.Columns[3].HeaderText = "Precio de Bandera";
            dgv.Columns[4].HeaderText = "Precio por Metros";
            dgv.Columns[5].HeaderText = "Precio por Minuto";
            dgv.Columns[0].DisplayIndex = dgv.Columns.Count - 1;

            textoCabecera = "Usted está viendo: Tarifas";
            lblBase.Text = textoCabecera;
        }

        private void tsbCarrera_Click(object sender, EventArgs e)
        {
            if (dgv.Columns[0].Visible == false && usu.AccesoUsuario == 1) //Si soy ADMIN y el Del esta invisible lo activo
                dgv.Columns[0].Visible = true;

            dgv.DataSource = LNyAD.TablaCarreras(); //Llenamos el DataGridView a partir de un DataTable
            dgv.Columns["idCarrera"].Visible = false; //Ocultamos los IDs
            dgv.Columns["idConductor"].Visible = false; //Ocultamos los IDs
            dgv.Columns["idCliente"].Visible = false; //Ocultamos los IDs
            dgv.Columns["idTarifa"].Visible = false; //Ocultamos los IDs
            dgv.Columns[2].HeaderText = "Origen";
            dgv.Columns[3].HeaderText = "Destino";
            dgv.Columns[4].HeaderText = "Fecha";
            dgv.Columns[5].HeaderText = "Metros";
            dgv.Columns[6].HeaderText = "Duración";
            dgv.Columns[10].HeaderText = "Tarifa";
            dgv.Columns[11].HeaderText = "Conductor";
            dgv.Columns[12].HeaderText = "Cliente";
            dgv.Columns[0].DisplayIndex = dgv.Columns.Count - 1;

            textoCabecera = "Usted está viendo: Carreras";
            lblBase.Text = textoCabecera;

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Admin iuAdmin = new Admin();
            iuAdmin.UsuarioDentro = usu; //Mando el usuario al siguiente formulario
            iuAdmin.ShowDialog();
            iuAdmin.Dispose();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
