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
    public partial class EditConductor : Form
    {
        Conductores cond;
        bool nuevo;
        double val;
        int val2;
        public Conductores Cond
        {
            get
            {
                return cond;
            }

            set
            {
                cond = value;
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

        public EditConductor()
        {
            InitializeComponent();
        }

        private void EditConductor_Load(object sender, EventArgs e)
        {
            if (!nuevo) //Si estoy editando relleno con los valores a editar
            {
                txbID.Visible = true;
                labelID.Visible = true;
                txbNombre.Text = cond.NombreConductor;
                txbApellidos.Text = cond.ApellidosConductor;
                txbDireccion.Text = cond.DireccionConductor;
                txbEmail.Text = cond.EmailConductor;
                txbDNI.Text = cond.DniConductor;
                txbLicencia.Text = cond.LicenciaConductor.ToString();
                txbMatricula.Text = cond.MatriculaConductor;
                txbID.Text = cond.IdConductor.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!HayErrorEnFormulario())
            {
                cond.NombreConductor = txbNombre.Text;
                cond.ApellidosConductor = txbApellidos.Text;
                cond.DireccionConductor = txbDireccion.Text;
                cond.EmailConductor = txbEmail.Text;
                cond.DniConductor = txbDNI.Text;
                cond.LicenciaConductor = Convert.ToInt32(txbLicencia.Text);
                cond.MatriculaConductor = txbMatricula.Text;

                LNyAD.EditarConductor(cond);
                MessageBox.Show("Operación realizada", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private bool HayErrorEnFormulario()
        {
            errorProvider1.Clear();

            string text = "";
            bool error = false;
            if (txbNombre.Text == cond.NombreConductor && txbApellidos.Text == cond.ApellidosConductor && txbDireccion.Text == cond.DireccionConductor
                && txbEmail.Text == cond.EmailConductor && txbDNI.Text == cond.DniConductor && txbLicencia.Text == cond.LicenciaConductor.ToString()
                && txbMatricula.Text == cond.MatriculaConductor && !nuevo) //Si todos los campos son iguales ERROR
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
            if (!Regex.IsMatch(txbEmail.Text, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")) //Email fomrato ERROR
            {
                text += "Formato de correo electronico incorrecto\n";
                error = true;
                errorProvider1.SetError(txbEmail, "Error de formato");
            }
            if (txbDNI.Text.Length == 10) //DNI fomato ERROR
            {
                if (txbDNI.Text[8] != '-' || (txbDNI.Text[9] > 'Z' || txbDNI.Text[9] < 'A') || !double.TryParse(txbDNI.Text.Substring(0, 8), out val))
                {
                    text += "Formato de DNI incorrecto\n";
                    error = true;
                    errorProvider1.SetError(txbDNI, "Error de formato");
                }
                else if (LNyAD.TablaConductoresDNI(txbDNI.Text).Count != 0 && txbDNI.Text != cond.DniConductor) //Comprobar Asociacion Carrera ERROR
                {
                    text += "Ya existe un Conductor con este DNI\n";
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
            if (txbMatricula.Text.Length == 7) //Campo Matricula formato ERROR
            {
                if (!Int32.TryParse(txbMatricula.Text.Substring(0, 4), out val2) || (txbMatricula.Text[4] > 'Z'
                || txbMatricula.Text[4] < 'A') || (txbMatricula.Text[5] > 'Z' || txbMatricula.Text[5] < 'A') || (txbMatricula.Text[6] > 'Z' || txbMatricula.Text[6] < 'A'))
                {
                    text += "Formato Matricula incorrecto\n";
                    error = true;
                    errorProvider1.SetError(txbMatricula, "Formato");
                }
            }
            else
            {
                text += "Formato de Matricula incorrecto\n";
                error = true;
                errorProvider1.SetError(txbMatricula, "Error de formato");
            }

            if (txbLicencia.Text == String.Empty) //Campo Licencia vacio ERROR
            {
                text += "Campo Licencia vacio\n";
                error = true;
                errorProvider1.SetError(txbLicencia, "Vacio");
            }
            else if (!Double.TryParse(txbLicencia.Text, out val) || val <= 0) //Licencia formato ERROR
            {
                text += "Campo Licencia debe ser numérico\n";
                error = true;
                errorProvider1.SetError(txbLicencia, "Formato");
            }
            if (error)
                MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return error;
        }
    }
}
