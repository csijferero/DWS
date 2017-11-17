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
        string parametro;

        //// Constructor por defecto (No lo vamos a utilizar)
        //public Form2()
        //{
        //    InitializeComponent();
        //}

        // Constructor que nos servirá para recibir los parámetros
        public Form2(string parametro)
        {
            InitializeComponent(); // <-- NO olvidar esto

            this.parametro = parametro;
            textBox2.Text = parametro;
        }

        // Propiedad que servirá de intermediario "de correo"
        public string Parametro
        {
            get { return parametro; }
            set { parametro = value; }
        }

        private void buttonF2_Click(object sender, EventArgs e)
        {
            // Antes de cerrar actualizamos el/los parámetros
            parametro = textBox2.Text;
            // Este es el valor que devuelve el formulatio al cerrarse
            this.DialogResult = DialogResult.OK; 
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
