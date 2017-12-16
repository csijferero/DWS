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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dgvClientes.BorderStyle = BorderStyle.None; //Quita los bordes del DGV
            dgvClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249); //Color de fondo de la fila NO seleccionada
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; // Deja unicamente los bordes horizontales
            dgvClientes.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise; //Color de fondo de la fila seleccionada
            dgvClientes.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke; //Color de las letras de la fila seleccionada
            dgvClientes.BackgroundColor = Color.White; //Color de fondo del DGV

            dgvClientes.EnableHeadersVisualStyles = false; //Deshabilita el tema por defecto del Header
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; //Quita los bordes del Header
            dgvClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72); //Color de fondo del Header
            dgvClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; //Color de las letras del Header


            //List<Clientes> listaClientes = LNyAD.listaClientes(); //Rellenamos la lista desde la BD
            dgvClientes.DataSource = LNyAD.tablaClientes(); //Llenamos el DataGridView a partir de un DataTable
            dgvClientes.Columns["idCliente"].Visible = false; //Ocultamos los IDs
            //Cambiamos las cabeceras del DataGridView
            dgvClientes.Columns[1].HeaderText = "Nombre";
            dgvClientes.Columns[2].HeaderText = "Apellidos";
            dgvClientes.Columns[3].HeaderText = "Domicilio";
            dgvClientes.Columns[4].HeaderText = "Email";
            dgvClientes.Columns[5].HeaderText = "DNI";
        }
    }
}
