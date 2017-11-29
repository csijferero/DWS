using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GestionAlumnosFP_V1
{
    public partial class FormDetalleAlumno : Form
    {
        Alumno alum;
        public FormDetalleAlumno()
        {
            InitializeComponent();
        }

        public Alumno Alum
        {
            get
            {
                return alum;
            }

            set
            {
                alum = value;
            }
        }

        private void FormDetalleAlumno_Load(object sender, EventArgs e)
        {
            // si indice es negativo oculto el textBox, en caso contrario lo muestro
            txbIndice.Visible = (alum.IdAlumno >= 0);

            txbIndice.Text = alum.IdAlumno.ToString();
            txbApellNom.Text = alum.ApellidosNombre;
            txbDni.Text = alum.Dni;
            txbMovil.Text = alum.Movil;
            txbTelefono.Text = alum.Telefono;
            txbMail.Text = alum.Email;
            cbGruposDetalle.SelectedValue = alum.IdGrupo;
            if (alum.IdGrupo < 0)
                cbGruposDetalle.Text = "Seleccione un grupo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (HayErrorEnFormulario())
                return;


            // actualizo el alumno
            alum.ApellidosNombre = txbApellNom.Text;
            alum.Dni = txbDni.Text;
            alum.Movil = txbMovil.Text;
            alum.Telefono = txbTelefono.Text;
            alum.Email = txbMail.Text;
            alum.IdGrupo = (int)cbGruposDetalle.SelectedValue;

            // Me salgo respondiendo OK
            this.DialogResult = DialogResult.OK;
        }

        private bool HayErrorEnFormulario()
        {
            errorProvider1.Clear();
            bool error = false;


            if (txbApellNom.Text == String.Empty || (txbTelefono.Text == String.Empty && txbMovil.Text == String.Empty) || cbGruposDetalle.Text == String.Empty)
            {
                error = true;
            }
            if ((txbMovil.Text.Length != 9 || (txbMovil.Text.Substring(0, 1) != "6" && txbMovil.Text.Substring(0, 1) != "7")) && txbMovil.Text.Length != 0)
            {
                error = true;
                errorProvider1.SetError(txbMovil, "Error de formato");
            }
            if ((txbTelefono.Text.Length != 9 || (txbTelefono.Text.Substring(0, 3) != "954" && txbTelefono.Text.Substring(0, 3) != "955")) && txbTelefono.Text.Length != 0)
            {
                error = true;
                errorProvider1.SetError(txbTelefono, "Error de formato");
            }
            if (!Regex.IsMatch(txbMail.Text, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
            {
                error = true;
                errorProvider1.SetError(txbMail, "Error de formato");
            }


            return error;
        }
    }
}
