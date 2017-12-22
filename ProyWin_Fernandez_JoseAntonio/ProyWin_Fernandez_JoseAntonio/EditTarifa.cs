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
    public partial class EditTarifa : Form
    {
        Tarifas tar;
        bool nuevo;
        double val;
        public Tarifas Tar
        {
            get
            {
                return tar;
            }

            set
            {
                tar = value;
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

        public EditTarifa()
        {
            InitializeComponent();
        }

        private void EditTarifa_Load(object sender, EventArgs e)
        {
            if (!nuevo) //Si estoy editando relleno con los valores a editar
            {
                txbID.Visible = true;
                labelID.Visible = true;
                txbNumero.Text = tar.NumeroTarifa.ToString();
                txbMetros.Text = tar.PrecioMetros.ToString();
                txbDuracion.Text = tar.PrecioDuracion.ToString();
                txbBandera.Text = tar.PrecioBandera.ToString();
                txbID.Text = tar.IdTarifa.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!HayErrorEnFormulario())
            {
                tar.NumeroTarifa = Convert.ToDouble(txbNumero.Text);
                tar.PrecioMetros = Convert.ToDouble(txbMetros.Text);
                tar.PrecioDuracion = Convert.ToDouble(txbDuracion.Text);
                tar.PrecioBandera = Convert.ToDouble(txbBandera.Text);

                LNyAD.EditarTarifa(tar);
                MessageBox.Show("Operación realizada", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private bool HayErrorEnFormulario()
        {
            errorProvider1.Clear();

            string text = "";
            bool error = false;
            if (txbNumero.Text == tar.NumeroTarifa.ToString() && txbMetros.Text == tar.PrecioMetros.ToString() && txbDuracion.Text == tar.PrecioDuracion.ToString()
                && txbBandera.Text == tar.PrecioBandera.ToString() && !nuevo) //Si todos los campos son iguales ERROR
            {
                text += "No se ha realizado ningun cambio\n";
                error = true;
            }
            if (!double.TryParse(txbNumero.Text, out val) || val<=0) //Campo Numero Tarifa formato ERROR
            {
                text += "Campo Numero Tarifa erroneo\n";
                error = true;
                errorProvider1.SetError(txbNumero, "Error de formato");
            }
            else if (LNyAD.TablaTarifasNumero(Convert.ToDecimal(txbNumero.Text)).Count != 0 && txbNumero.Text!=tar.NumeroTarifa.ToString()) //Comprobar asociado a carrera ERROR
            {
                text += "Ya existe una Tarifa con este Numero\n";
                error = true;
                errorProvider1.SetError(txbNumero, "Repetido");
            }
            if (!double.TryParse(txbMetros.Text, out val) || val <= 0) //Campo Metros vacio formato ERROR
            {
                text += "Campo Precio Metros erroneo\n";
                error = true;
                errorProvider1.SetError(txbMetros, "Error de formato");
            }
            if (!double.TryParse(txbDuracion.Text, out val) || val <= 0) //Campo Duracion vacio formato ERROR
            {
                text += "Campo Precio Duracion erroneo\n";
                error = true;
                errorProvider1.SetError(txbDuracion, "Error de formato");
            }
            if (!double.TryParse(txbBandera.Text, out val) || val <= 0) //Campo Bandera vacio formato ERROR
            {
                text += "Campo Precio Bandera erroneo\n";
                error = true;
                errorProvider1.SetError(txbBandera, "Error de formato");
            }
            if (error)
                MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return error;
        }
    }
}
