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
        decimal val;

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
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Si pulso borrar...
            if (e.RowIndex >= 0 && dgv.Columns[dgv.CurrentCell.ColumnIndex].HeaderText == "Del"
                && (MessageBox.Show("¿Está seguro de que desea borrar el registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {

                if (dgv.Columns[1].HeaderText == "idCliente") //Y quiero borrar un cliente
                {
                    if (LNyAD.ComprobarAsociacionCliente(Convert.ToInt32(dgv.Rows[dgv.CurrentRow.Index].Cells[1].Value.ToString())).Count != 0)
                    {
                        MessageBox.Show("El Cliente está asociado a una Carrera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        LNyAD.BorarCliente(Convert.ToInt32(dgv.Rows[dgv.CurrentRow.Index].Cells[1].Value.ToString()));
                        tsbCliente_Click(null, null);
                    }
                }
                else if (dgv.Columns[1].HeaderText == "idConductor") //Y quiero borrar un conductor
                {
                    if (LNyAD.ComprobarAsociacionConductor(Convert.ToInt32(dgv.Rows[dgv.CurrentRow.Index].Cells[1].Value.ToString())).Count != 0)
                    {
                        MessageBox.Show("El Conductor está asociado a una Carrera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        LNyAD.BorarConductor(Convert.ToInt32(dgv.Rows[dgv.CurrentRow.Index].Cells[1].Value.ToString()));
                        tsbConductor_Click(null, null);
                    }
                }
                else if (dgv.Columns[1].HeaderText == "idTarifa") //Y quiero borrar un conductor
                {
                    if (LNyAD.ComprobarAsociacionTarifa(Convert.ToInt32(dgv.Rows[dgv.CurrentRow.Index].Cells[1].Value.ToString())).Count != 0)
                    {
                        MessageBox.Show("La Tarifa está asociado a una Carrera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        LNyAD.BorarTarifa(Convert.ToInt32(dgv.Rows[dgv.CurrentRow.Index].Cells[1].Value.ToString()));
                        tsbTarifa_Click(null, null);
                    }
                }
                else if (dgv.Columns[1].HeaderText == "idCarrera") //Y quiero borrar un conductor
                {
                    LNyAD.BorarCarrera(Convert.ToInt32(dgv.Rows[dgv.CurrentRow.Index].Cells[1].Value.ToString()));
                    tsbCarrera_Click(null, null);
                }
                //Reseteo los parametros de busqueda
                txbBusqueda.Text = String.Empty;
                dateTimePicker1.Value = DateTime.Today;
            }
        }

        private void tsbCliente_Click(object sender, EventArgs e)
        {

            dgv.DataSource = LNyAD.TablaClientes(); //Llenamos el DataGridView a partir de un DataTable
            dgv.Columns["idCliente"].Visible = false; //Ocultamos los IDs
            dgv.Columns[2].HeaderText = "Nombre";
            dgv.Columns[3].HeaderText = "Apellidos";
            dgv.Columns[4].HeaderText = "Domicilio";
            dgv.Columns[5].HeaderText = "Email";
            dgv.Columns[6].HeaderText = "DNI";
            dgv.Columns[0].DisplayIndex = dgv.Columns.Count - 1;

            lblBase.Text = "Usted está viendo: Clientes";
            labelBusqueda.Text = "DNI";
        }

        private void tsbConductor_Click(object sender, EventArgs e)
        {

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

            lblBase.Text = "Usted está viendo: Conductores";
            labelBusqueda.Text = "Matricula";
        }

        private void tsbTarifa_Click(object sender, EventArgs e)
        {

            dgv.DataSource = LNyAD.TablaTarifas(); //Llenamos el DataGridView a partir de un DataTable
            dgv.Columns["idTarifa"].Visible = false; //Ocultamos los IDs
            dgv.Columns[2].HeaderText = "Tarifa";
            dgv.Columns[3].HeaderText = "Precio de Bandera";
            dgv.Columns[4].HeaderText = "Precio por Metros";
            dgv.Columns[5].HeaderText = "Precio por Minuto";
            dgv.Columns[0].DisplayIndex = dgv.Columns.Count - 1;

            lblBase.Text = "Usted está viendo: Tarifas";
            labelBusqueda.Text = "Numero Tarifa";
        }

        private void tsbCarrera_Click(object sender, EventArgs e)
        {

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

            lblBase.Text = "Usted está viendo: Carreras";
            labelBusqueda.Text = "Fecha";
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Admin iuAdmin = new Admin();
            iuAdmin.UsuarioDentro = usu; //Mando el usuario al siguiente formulario
            iuAdmin.ShowDialog();
            iuAdmin.Dispose();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e) //FILTROS DE BUSQUEDA
        {
            if (labelBusqueda.Text == "DNI") //Si el DGV es de clientes...
                dgv.DataSource = LNyAD.TablaClientesDNI(txbBusqueda.Text);
            else if (labelBusqueda.Text == "Matricula") //Si el DGV es de conductores...
                dgv.DataSource = LNyAD.TablaConductoresMatricula(txbBusqueda.Text);
            else if (labelBusqueda.Text == "Numero Tarifa") //Si el DGV es de tarifas...
            {
                if (decimal.TryParse(txbBusqueda.Text, out val)) //Y la busqueda es decimal...
                    dgv.DataSource = LNyAD.TablaTarifasNumero(val);
                else //Si no los muestro todos
                {
                    dgv.DataSource = LNyAD.TablaTarifas();
                }
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) //Activacion de los Filtros de busqueda
        {
            if (dgv.Columns[0].Visible == false && usu.AccesoUsuario == 1) //Si soy ADMIN y el Del esta invisible lo activo
            {
                dgv.Columns[0].Visible = true;
                btnAñadir.Enabled = true;
            }

            //Activo los parametros de busqueda
            labelBusqueda.Visible = true;
            if (e.ClickedItem.Text != "Carreras")
            {
                txbBusqueda.Text = String.Empty;
                txbBusqueda.Visible = true;
                dateTimePicker1.Visible = false;
            }
            else
            {
                dateTimePicker1.Value = DateTime.Today;
                dateTimePicker1.Visible = true;
                txbBusqueda.Visible = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (labelBusqueda.Text == "Fecha") //Si el DGV es de carreras...
            {
                dgv.DataSource = LNyAD.TablaCarrerasFecha(dateTimePicker1.Value);
                dgv.Columns[0].DisplayIndex = dgv.Columns.Count - 1;
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (labelBusqueda.Text == "DNI")
            {
                EditCliente iuCli = new EditCliente();
                iuCli.Cli = new Clientes(); //Mando la fila al siguiente formulario
                iuCli.Nuevo = true;
                iuCli.ShowDialog();
                iuCli.Dispose();
                dgv.DataSource = LNyAD.TablaClientes(); //Llenamos el DataGridView a partir de un DataTable (ACTUALIZAR)
            }
            else if (labelBusqueda.Text == "Matricula")
            {
                EditConductor iuCond = new EditConductor();
                iuCond.Cond = new Conductores(); //Mando la fila al siguiente formulario
                iuCond.Nuevo = true;
                iuCond.ShowDialog();
                iuCond.Dispose();
                dgv.DataSource = LNyAD.TablaConductores(); //Llenamos el DataGridView a partir de un DataTable (ACTUALIZAR)
            }
            else if (labelBusqueda.Text == "Numero Tarifa")
            {
                EditTarifa iuTar = new EditTarifa();
                iuTar.Tar = new Tarifas(); //Mando la fila al siguiente formulario
                iuTar.Nuevo = true;
                iuTar.ShowDialog();
                iuTar.Dispose();
                dgv.DataSource = LNyAD.TablaTarifas(); //Llenamos el DataGridView a partir de un DataTable (ACTUALIZAR)
            }
            else if (labelBusqueda.Text == "Fecha")
            {
                EditCarreras iuCarr = new EditCarreras();
                iuCarr.Car = new Carreras(); //Mando la fila al siguiente formulario
                iuCarr.Nuevo = true;
                iuCarr.ShowDialog();
                iuCarr.Dispose();
                dgv.DataSource = LNyAD.TablaCarreras(); //Llenamos el DataGridView a partir de un DataTable (ACTUALIZAR)
                dgv.Columns[0].DisplayIndex = dgv.Columns.Count - 1;
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //Doble Click para Actualizar
        {
            if (usu.AccesoUsuario == 1 && e.RowIndex >= 0)
            {
                if (labelBusqueda.Text == "DNI")
                {
                    EditCliente iuCli = new EditCliente();
                    iuCli.Cli = LNyAD.ObtenerCliente(Convert.ToInt32(dgv.Rows[dgv.CurrentRow.Index].Cells[1].Value.ToString())); //Mando la fila al siguiente formulario
                    iuCli.Nuevo = false;
                    iuCli.ShowDialog();
                    iuCli.Dispose();
                    dgv.DataSource = LNyAD.TablaClientes(); //Llenamos el DataGridView a partir de un DataTable (ACTUALIZAR)
                }
                else if (labelBusqueda.Text == "Matricula")
                {
                    EditConductor iuCond = new EditConductor();
                    iuCond.Cond = LNyAD.ObtenerConductor(Convert.ToInt32(dgv.Rows[dgv.CurrentRow.Index].Cells[1].Value.ToString())); //Mando la fila al siguiente formulario
                    iuCond.Nuevo = false;
                    iuCond.ShowDialog();
                    iuCond.Dispose();
                    dgv.DataSource = LNyAD.TablaConductores(); //Llenamos el DataGridView a partir de un DataTable (ACTUALIZAR)
                }
                else if (labelBusqueda.Text == "Numero Tarifa")
                {
                    EditTarifa iuTar = new EditTarifa();
                    iuTar.Tar = LNyAD.ObtenerTarifa(Convert.ToInt32(dgv.Rows[dgv.CurrentRow.Index].Cells[1].Value.ToString())); //Mando la fila al siguiente formulario
                    iuTar.Nuevo = false;
                    iuTar.ShowDialog();
                    iuTar.Dispose();
                    dgv.DataSource = LNyAD.TablaTarifas(); //Llenamos el DataGridView a partir de un DataTable (ACTUALIZAR)
                }
                else if (labelBusqueda.Text == "Fecha")
                {
                    EditCarreras iuCarr = new EditCarreras();
                    iuCarr.Car = LNyAD.obtenerCarrera(Convert.ToInt32(dgv.Rows[dgv.CurrentRow.Index].Cells[1].Value.ToString())); //Mando la fila al siguiente formulario
                    iuCarr.Nuevo = false;
                    iuCarr.ShowDialog();
                    iuCarr.Dispose();
                    dgv.DataSource = LNyAD.TablaCarreras(); //Llenamos el DataGridView a partir de un DataTable (ACTUALIZAR)
                    dgv.Columns[0].DisplayIndex = dgv.Columns.Count - 1;
                }
            }
        }
    }
}
