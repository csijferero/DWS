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
using System.Text.RegularExpressions;

namespace InterfazUsuario
{
    public partial class EditCliente : Form
    {
        Clientes cli;
        bool nuevo;
        double val;
        public Clientes Cli
        {
            get
            {
                return cli;
            }

            set
            {
                cli = value;
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

        public EditCliente()
        {
            InitializeComponent();
        }

        private void EditCliente_Load(object sender, EventArgs e)
        {
            if (!nuevo) //Si estoy editando relleno con los valores a editar
            {
                txbID.Visible = true;
                labelID.Visible = true;
                txbNombre.Text = cli.NombreCliente;
                txbApellidos.Text = cli.ApellidosCliente;
                txbDireccion.Text = cli.DireccionCliente;
                txbEmail.Text = cli.EmailCliente;
                txbDNI.Text = cli.DniCliente;
                txbID.Text = cli.IdCliente.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!HayErrorEnFormulario())
            {
                cli.NombreCliente = txbNombre.Text;
                cli.ApellidosCliente = txbApellidos.Text;
                cli.DireccionCliente = txbDireccion.Text;
                cli.EmailCliente = txbEmail.Text;
                cli.DniCliente = txbDNI.Text;

                LNyAD.EditarCliente(cli);
                MessageBox.Show("Operación realizada", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private bool HayErrorEnFormulario()
        {
            errorProvider1.Clear();

            string text = "";
            bool error = false;
            if (txbNombre.Text == cli.NombreCliente && txbApellidos.Text == cli.ApellidosCliente && txbDireccion.Text == cli.DireccionCliente
                && txbEmail.Text == cli.EmailCliente && txbDNI.Text == cli.DniCliente && !nuevo) //Si todos los campos son iguales ERROR
            {
                text += "No se ha realizado ningun cambio\n";
                error = true;
            }
            if (txbNombre.Text == String.Empty) //Campo Nombre vacio ERROR
            {
                text += "Campo Nombre vacio\n";
                error = true;
                errorProvider1.SetError(txbNombre, "Vacio");
            }
            if (txbApellidos.Text == String.Empty) //Campo Apellidos vacio ERROR
            {
                text += "Campo Apellidos vacio\n";
                error = true;
                errorProvider1.SetError(txbApellidos, "Vacio");
            }
            if (txbDireccion.Text == String.Empty) //Campo Direccion vacio ERROR
            {
                text += "Campo Direccion vacio\n";
                error = true;
                errorProvider1.SetError(txbDireccion, "Vacio");
            }
            if (!Regex.IsMatch(txbEmail.Text, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")) //Formato Email ERROR
            {
                text += "Formato de correo electronico incorrecto\n";
                error = true;
                errorProvider1.SetError(txbEmail, "Error de formato");
            }
            if (txbDNI.Text.Length == 10) //Formato DNI ERROR
            {
                if (txbDNI.Text[8] != '-' || (txbDNI.Text[9] > 'Z' || txbDNI.Text[9] < 'A') || !double.TryParse(txbDNI.Text.Substring(0, 8), out val))
                {
                    text += "Formato de DNI incorrecto\n";
                    error = true;
                    errorProvider1.SetError(txbDNI, "Error de formato");
                }
                else if (LNyAD.TablaClientesDNI(txbDNI.Text).Count != 0 && txbDNI.Text != cli.DniCliente) //Comprobar asociacion Carrera ERROR
                {
                    text += "Ya existe un Cliente con este DNI\n";
                    error = true;
                    errorProvider1.SetError(txbDNI, "Repetido");
                }
            }
            else
            {
                text += "Formato de DNI incorrecto\n";
                error = true;
                errorProvider1.SetError(txbDNI, "Error de formato");
            }
            if (error)
                MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return error;
        }
    }
}
