/* La forma más práctica y más utilizada para pasar parámetros
 * de un formulario a otro es a través del constructor del Form "receptor".
 * Este es el Form que va a controlar el proceso.
 * Como ejemplo MSP, sólo vamos a enviar un texto a otro formulario
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
        public Form1()
        {
            InitializeComponent();
        }

        // Cuando pulsemos el botón...
        private void button1_Click(object sender, EventArgs e)
        {
            //... Si hemos escrito algo en el textBox...
            if (textBox1.Text.Length > 0)
            {
                //... Construyo el formulario "receptor" 
                // pasándole como parámetro el valor que queremos.
                // Por supuesto, previamente habremos sobrecargado el constructor de Form2
                Form2 form2 = new Form2(textBox1.Text);

                // vacío la caja te texto para que sea más intuitivo
                textBox1.Text = string.Empty;

                // Lo lanzamos como diálogo de éste
                DialogResult dialogo  = form2.ShowDialog();

                
                // Si hemos cerrado bien el Form2, accedemos a su propiedad Texto"
                if (dialogo == DialogResult.OK)
                    textBox1.Text = form2.Parametro;

                MessageBox.Show("Fíjate que form2 todavía existe aunque esté oculto\nPulsa para mostrar");
                form2.Show();
                // Si de verdad queremos eliminarlo hay que hacer «Dispose»
                //form2.Dispose();
            }
            else
                MessageBox.Show("La longitud del texto debe ser de al menos 1 caracter.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
