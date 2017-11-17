/* Forma Basta: No sé si MBP:)
 * Haciendo que éste sea propietario «Owner» del form2 y luego, desde form2
 * acceder a las propiedades públicas de su propietario.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DEMO_Datos_entre_Forms
{
    public partial class Form1 : Form
    {
        Form2 fRelac;
        public Form1()
        {
            InitializeComponent();
        }
        // Propiedad que servirá de intermediario "de correo"
        public string ParametroDfom1
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public Form2 FormRelacionado
        {
            set { fRelac = value; }
        }

        // Cuando pulsemos el botón...
        private void button1_Click(object sender, EventArgs e)
        {
            //... Si hemos escrito algo en el textBox...
            if (textBox1.Text.Length > 0)
            {
                //... Construyo el formulario "receptor" form2
                fRelac.ParametroDform2 = textBox1.Text;

                //MessageBox.Show("Fíjate que form2 todavía existe aunque esté oculto\nPulsa para mostrar");
                //form2.Show();
                // Si de verdad queremos eliminarlo hay que hacer «Dispose»
                // form2.Dispose();
            }
            else
                MessageBox.Show("La longitud del texto debe ser de al menos 1 caracter.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
