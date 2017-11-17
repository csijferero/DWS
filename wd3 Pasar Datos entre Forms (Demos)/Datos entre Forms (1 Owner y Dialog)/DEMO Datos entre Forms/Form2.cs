/* Como se lanza mediante ShowDialog
 * Hacemos que Se cierre mediante su DialogoResult y en función del resultado
 * form1 tomará su parámetro */
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
        string parametroDform2;

        // Constructor por defecto (es el que vamos a utilizar)
        public Form2()
        {
            InitializeComponent();
            
        }
        // Podemos capturar de su propietario los parámetros públicos
        // Ojo, que esto no está disponible en el constructor
        private void Form2_Load(object sender, EventArgs e)
        {
            textBox2.Text = ((Form1)(this.Owner)).ParametroDfom1;
        }

        // Propiedad que servirá de intermediario "de correo"
        public string Parametro
        {
            get { return parametroDform2; }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Antes de cerrar actualizamos el/los parámetros
            parametroDform2 = textBox2.Text;
            // Este es el valor que devuelve el formulatio al cerrarse
            this.DialogResult = DialogResult.OK; 
        }


    }
}
