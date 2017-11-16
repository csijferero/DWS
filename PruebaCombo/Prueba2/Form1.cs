using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba2
{
    public partial class Form1 : Form
    {
        List<Pintura> listaPinturas = new List<Pintura>();
        bool comboCargado = false;
        Color nuevoColor;
        public Form1()
        {
            InitializeComponent();

        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboCargado)
            //{
            lbColor.BackColor = ((Pintura)(cbColor.SelectedItem))._Color;
            //}

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaPinturas.Add(new Pintura(Color.Blue, "Azul", 4.0));
            listaPinturas.Add(new Pintura(Color.Red, "Rojo", 3.45));
            listaPinturas.Add(new Pintura(Color.Orange, "Naranja", 6.40));
            listaPinturas.Add(new Pintura(Color.Lime, "Verde", 4.15));


            // Enlazamos el combo a la lista
            //cbColor.DataSource = listaPinturas;
            //cbColor.DisplayMember = "Nombre"; // <-- Indicamos la propiedad que se verá
            //cbColor.ValueMember = "_Color"; // <-- Indicamos la propiedad que se guardará en value
            foreach (Pintura p in listaPinturas)
                cbColor.Items.Add(p);
            cbColor.DisplayMember = "Nombre"; // <-- Indicamos la propiedad que se verá


            cbColor.SelectedIndex = -1;
            cbColor.Text = "Selecciona un Color";
            comboCargado = true;

            nuevoColor = this.BackColor;
        }

        private void btnEligeColor_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == colorDialog1.ShowDialog())
            {
                btnEligeColor.BackColor = colorDialog1.Color;
                nuevoColor = colorDialog1.Color;
            }
        }
        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            if (HayError())
                return;

            double precio = Convert.ToDouble(txtPrecio.Text);

            // si no hay error añado la pintura a la lista y al combo
            listaPinturas.Add(new Pintura(nuevoColor, txtNombreColor.Text, precio));
            cbColor.Items.Add(new Pintura(nuevoColor, txtNombreColor.Text, precio));

            MessageBox.Show("La pintura ha sido añadida a la lista", "Operación OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        bool HayError()
        {
            bool error = false;
            string mensajeError = "";
            double precio;
            errorProvider1.Clear();

            if (txtNombreColor.Text.Length < 1)
            {
                error = true;
                mensajeError = "Debe escribir el nombre del color\n";

            }
            else
            {
                foreach (Pintura p in listaPinturas)
                    if (txtNombreColor.Text == p.Nombre)
                    {
                        error = true;
                        mensajeError += "Ya existe un color con dicho nombre\n";
                        break;
                    }
            }

            if (txtPrecio.Text.Length < 1)
            {
                error = true;
                mensajeError += "Debe introducir el precio\n";
            }
            else if (!Double.TryParse(txtPrecio.Text, out precio))
            {
                error = true;
                mensajeError += "No ha indicado un precio válido\n";
            }

            if (nuevoColor == this.BackColor)
            {
                error = true;
                mensajeError += "Debe elegir un color\n";
            }
            else
            {
                foreach (Pintura p in listaPinturas)
                    if (nuevoColor == p._Color)
                    {
                        error = true;
                        mensajeError += "Ya existe el color elegido\n";
                        break;
                    }
            }

            if (error)
                MessageBox.Show(mensajeError, "Hay error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return error;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool borrado = false;
            for (int i = 0; i < listaPinturas.Count; i++)
            {
                if (textBorrarColor.Text == listaPinturas[i].Nombre)
                {
                    listaPinturas.RemoveAt(i);
                    cbColor.Items.RemoveAt(i);
                    MessageBox.Show("Se ha eliminado la pintura con exito", "Operación OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    borrado = true;
                    break;
                }
            }

            if (!borrado)
                MessageBox.Show("Escriba un nombre del color a borrar existente", "Hay error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}