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
        Form1 form1;

        // Constructor por defecto (No lo vamos a utilizar)
        public Form2()
        {
            InitializeComponent();
            
        }
        // Podemos capturar de su propietario los parámetros públicos
        // Ojo, que esto no está disponible en el constructor
        private void Form2_Load(object sender, EventArgs e)
        {
                form1=((Form1)(this.Owner));
                textBox2.Text = form1.ParametroDfom1;
        }

        // Propiedad que servirá de intermediario "de correo"
        public string Parametro
        {
            get { return textBox2.Text; }
        }

        private void buttonF2_Click(object sender, EventArgs e)
        {
            // Actualizamos el texBox de form1
            form1.ParametroDfom1 = textBox2.Text;
        }
    }
}
