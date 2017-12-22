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
        bool nuevo;
        double val;
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

        public bool Nuevo
        {
            get
            {
                return nuevo;
            }

            set
            {
                nuevo = value;
            }
        }

        public EditCarreras()
        {
            InitializeComponent();
        }

        private void EditCarreras_Load(object sender, EventArgs e)
        {
            CargaCombo();
            if (!nuevo) //Si estoy editando relleno con los valores a editar
            {
                txbID.Visible = true;
                labelID.Visible = true;
                txbOrigen.Text = car.Origen;
                txbDestino.Text = car.Destino;
                txbID.Text = car.IdCarrera.ToString();
                txbMetros.Text = car.Metros.ToString();
                txbDuracion.Text = car.Duracion.ToString();
                dateTimePicker1.Value = car.Fecha;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!HayErrorEnFormulario())
            {
                car.Origen = txbOrigen.Text;
                car.Destino = txbDestino.Text;
                car.Metros = Convert.ToInt32(txbMetros.Text);
                car.Duracion = Convert.ToInt32(txbDuracion.Text);
                car.IdCliente = Convert.ToInt32(cmbClient.SelectedValue.ToString());
                car.IdConductor = Convert.ToInt32(cmbCond.SelectedValue.ToString());
                car.IdTarifa = Convert.ToInt32(cmbTarifa.SelectedValue.ToString());
                car.Fecha = dateTimePicker1.Value;

                LNyAD.EditarCarrera(car);
                MessageBox.Show("Operación realizada", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void CargaCombo()
        {
            //Cargo los combos
            cmbClient.DataSource = LNyAD.ListaClientes();
            cmbCond.DataSource = LNyAD.ListaConductores();
            cmbTarifa.DataSource = LNyAD.ListaTarifas();

            //Indicamos las propiedades de cada Combo
            cmbClient.DisplayMember = "DniCliente";
            cmbClient.ValueMember = "IdCliente";
            cmbCond.DisplayMember = "DniConductor";
            cmbCond.ValueMember = "IdConductor";
            cmbTarifa.DisplayMember = "NumeroTarifa";
            cmbTarifa.ValueMember = "IdTarifa";

            //Coloco el valor actual del combo (Vacio si es nuevo registro)
            cmbClient.SelectedValue = car.IdCliente;
            cmbCond.SelectedValue = car.IdConductor;
            cmbTarifa.SelectedValue = car.IdTarifa;
        }

        private bool HayErrorEnFormulario()
        {
            errorProvider1.Clear();

            string text = "";
            bool error = false;
            if (txbMetros.Text == car.Metros.ToString() && txbOrigen.Text == car.Origen && txbDestino.Text == car.Destino
                && txbDuracion.Text == car.Duracion.ToString() && cmbClient.SelectedValue.ToString() == car.IdCliente.ToString()
                && cmbCond.SelectedValue.ToString() == car.IdConductor.ToString() && cmbTarifa.SelectedValue.ToString() == car.IdTarifa.ToString() && dateTimePicker1.Value == car.Fecha && !nuevo) //Si todos los campos son iguales ERROR
            {
                text += "No se ha realizado ningun cambio\n";
                error = true;
            }
            if (txbMetros.Text == String.Empty) //Campo Metros vacio ERROR
            {
                text += "Campo Metros vacio\n";
                error = true;
                errorProvider1.SetError(txbMetros, "Vacio");
            }
            else if (!Double.TryParse(txbMetros.Text, out val) || val <= 0)
            {
                text += "Campo Metros debe ser numérico\n";
                error = true;
                errorProvider1.SetError(txbMetros, "Formato");
            }
            if (txbOrigen.Text == String.Empty) //Campo Origen vacio ERROR
            {
                text += "Campo Origen vacio\n";
                error = true;
                errorProvider1.SetError(txbOrigen, "Vacio");
            }
            if (txbDestino.Text == String.Empty) //Campo Destino vacio ERROR
            {
                text += "Campo Destino vacio\n";
                error = true;
                errorProvider1.SetError(txbDestino, "Vacio");
            }
            if (txbDuracion.Text == String.Empty) //Campo Duracion vacio ERROR
            {
                text += "Campo Duracion vacio\n";
                error = true;
                errorProvider1.SetError(txbDuracion, "Vacio");
            }
            else if (!Double.TryParse(txbDuracion.Text, out val) || val <= 0)
            {
                text += "Campo Duracion debe ser numérico\n";
                error = true;
                errorProvider1.SetError(txbDuracion, "Formato");
            }
            if (cmbClient.Text == String.Empty) //Campo Cliente vacio ERROR
            {
                text += "Campo Cliente vacio\n";
                error = true;
                errorProvider1.SetError(cmbClient, "Vacio");
            }
            if (cmbCond.Text == String.Empty) //Campo Conductor vacio ERROR
            {
                text += "Campo Conductor vacio\n";
                error = true;
                errorProvider1.SetError(cmbCond, "Vacio");
            }
            if (cmbTarifa.Text == String.Empty) //Campo Tarifa vacio ERROR
            {
                text += "Campo Tarifa vacio\n";
                error = true;
                errorProvider1.SetError(cmbTarifa, "Vacio");
            }
            if (error)
                MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return error;
        }
    }
}
