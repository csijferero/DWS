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
    public partial class Form0 : Form
    {
        internal Form1 form1;
        internal Form2 form2;
        public Form0()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            form1 = new Form1();
            form2 = new Form2();

            form1.FormRelacionado = form2;
            form2.FormRelacionado = form1;

            form1.Show();
            form2.Show();


        }
    }
}
