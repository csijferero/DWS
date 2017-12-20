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
            btnAñadir.Enabled = false;
            //List<Clientes> listaClientes = LNyAD.listaClientes(); //Rellenamos la lista desde la BD


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
            //ffefefef
            textoCabecera = "Usted está viendo: Clientes";
            lblBase.Text = textoCabecera;
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
            textoCabecera = "Usted está viendo: Conductores";
            lblBase.Text = textoCabecera;
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
            textoCabecera = "Usted está viendo: Tarifas";
            lblBase.Text = textoCabecera;

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
    }
}
