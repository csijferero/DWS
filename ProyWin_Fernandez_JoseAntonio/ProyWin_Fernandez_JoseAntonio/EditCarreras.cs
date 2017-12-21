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
    public partial class EditCarreras : Form
    {
        Carreras car;
        public Carreras Car
        {
            get
            {
                return car;
            }

            set
            {
                car = value;
            }
        }

        public EditCarreras()
        {
            InitializeComponent();
        }

        private void EditCarreras_Load(object sender, EventArgs e)
        {
            //Cargo los combos
            List<Clientes> listaClientes = LNyAD.ListaClientes();
            listaClientes.Insert(0, new Clientes(0, "Seleccione un Cliente", "", "", "", ""));
            cmbClient.DataSource = listaClientes;
            cmbCond.DataSource = LNyAD.ListaConductores();
            cmbTarifa.DataSource = LNyAD.ListaTarifas();

            //Indicamos las propiedades de cada Combo
            cmbClient.DisplayMember = "NombreCliente";
            cmbClient.ValueMember = "IdCliente";
            cmbCond.DisplayMember = "NombreConductor";
            cmbCond.ValueMember = "IdConductor";
            cmbTarifa.DisplayMember = "NumeroTarifa";
            cmbTarifa.ValueMember = "IdTarifa";

            if (car.IdCliente < 0) //Si creo un registro nuevo el CMBCliente muestra...
            {
                cmbClient.Text = "Seleccione un Cliente";
                cmbCond.Text = "Seleccione un Conductor";
                cmbTarifa.Text = "Seleccione una Tarifa";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
