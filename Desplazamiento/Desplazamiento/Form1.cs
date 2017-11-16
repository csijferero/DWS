using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desplazamiento
{
    public partial class Form1 : Form
    {
        int red = 0;
        int green = 0;
        int blue = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Graphics grafico = CreateGraphics();
            blue = trackBar2.Value;
            textBox1.Text = trackBar2.Value.ToString();
            Brush brocha = new SolidBrush(Color.FromArgb(red, green, blue));
            grafico.FillRectangle(brocha, 500, 150, 200, 200);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            Graphics grafico = CreateGraphics();
            green = trackBar3.Value;
            textBox2.Text = trackBar3.Value.ToString();
            Brush brocha = new SolidBrush(Color.FromArgb(red, green, blue));
            grafico.FillRectangle(brocha, 500, 150, 200, 200);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Graphics grafico = CreateGraphics();
            red = trackBar1.Value;
            textBox3.Text = trackBar1.Value.ToString();
            Brush brocha = new SolidBrush(Color.FromArgb(red, green, blue));
            grafico.FillRectangle(brocha, 500, 150, 200, 200);
        }
    }
}