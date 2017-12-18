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
        public IUDatos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //List<Clientes> listaClientes = LNyAD.listaClientes(); //Rellenamos la lista desde la BD
            
            //Cambiamos las cabeceras del DataGridView
            

        }

        private void tsbCliente_Click(object sender, EventArgs e)
        {
            dgv.DataSource = LNyAD.tablaClientes(); //Llenamos el DataGridView a partir de un DataTable
            dgv.Columns["idCliente"].Visible = false; //Ocultamos los IDs
            dgv.Columns[1].HeaderText = "Nombre";
            dgv.Columns[2].HeaderText = "Apellidos";
            dgv.Columns[3].HeaderText = "Domicilio";
            dgv.Columns[4].HeaderText = "Email";
            dgv.Columns[5].HeaderText = "DNI";
        }

        private void tsbConductor_Click(object sender, EventArgs e)
        {
            dgv.DataSource = LNyAD.tablaConductores(); //Llenamos el DataGridView a partir de un DataTable
            dgv.Columns["idConductor"].Visible = false; //Ocultamos los IDs
            dgv.Columns[1].HeaderText = "Nombre";
            dgv.Columns[2].HeaderText = "Apellidos";
            dgv.Columns[3].HeaderText = "Domicilio";
            dgv.Columns[4].HeaderText = "Email";
            dgv.Columns[5].HeaderText = "DNI";
            dgv.Columns[6].HeaderText = "Licencia";
            dgv.Columns[7].HeaderText = "Matrícula";
        }

        private void tsbTarifa_Click(object sender, EventArgs e)
        {
            dgv.DataSource = LNyAD.tablaTarifas(); //Llenamos el DataGridView a partir de un DataTable
            dgv.Columns["idTarifa"].Visible = false; //Ocultamos los IDs
            dgv.Columns[1].HeaderText = "Tarifa";
            dgv.Columns[2].HeaderText = "Precio de Bandera";
            dgv.Columns[3].HeaderText = "Precio por Metros";
            dgv.Columns[4].HeaderText = "Precio por Minuto";
        }

        private void tsbCarrera_Click(object sender, EventArgs e)
        {
            dgv.DataSource = LNyAD.tablaCarreras(); //Llenamos el DataGridView a partir de un DataTable
            dgv.Columns["idCarrera"].Visible = false; //Ocultamos los IDs
            dgv.Columns["idConductor"].Visible = false; //Ocultamos los IDs
            dgv.Columns["idCliente"].Visible = false; //Ocultamos los IDs
            dgv.Columns["idTarifa"].Visible = false; //Ocultamos los IDs
            dgv.Columns[1].HeaderText = "Origen";
            dgv.Columns[2].HeaderText = "Destino";
            dgv.Columns[3].HeaderText = "Fecha";
            dgv.Columns[4].HeaderText = "Metros";
            dgv.Columns[5].HeaderText = "Duración";


        }
    }
}
