/* Como se lanza mediante Show, es independiente de form1
 * Hacemos que el botón sólo pasa el dato pero no cierra el formulario
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
    public partial class Form2 : Form
    {
        Form1 fRelac;
        // Constructor por defecto (No lo vamos a utilizar)
        public Form2()
        {
            InitializeComponent();
        }

        public Form1 FormRelacionado
        {
            set { fRelac = value; }
        }

        // Propiedad que servirá de intermediario "de correo"
        public string ParametroDform2
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        private void buttonF2_Click(object sender, EventArgs e)
        {
            // Actualizamos el texBox de form1
            fRelac.ParametroDfom1 = textBox2.Text;
        }
    }
}
