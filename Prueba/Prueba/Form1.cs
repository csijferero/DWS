using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Form1 : Form
    {

        Graphics gp;

        public Form1()
        {
            InitializeComponent();
            ResizeRedraw = true;
            Graficos();
        }

        public void Graficos()
        {
            gp = panel1.CreateGraphics();
        }

        private void boton_Click(object sender, EventArgs e)
        {
            Brush brocha = new SolidBrush(Color.Red);
            Pen pen = new Pen(brocha);
            for (int i = 0; i < panel1.Height; i++)
            {
                gp.DrawLine(pen, 0, i, panel1.Width, i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Brush brocha = new SolidBrush(Color.Blue);
            Pen pen = new Pen(brocha);
            gp.FillRectangle(brocha, 0, 0, panel1.Width, panel1.Height);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Brush brocha = new SolidBrush(Color.Yellow);
            Pen pen = new Pen(brocha);
            Point[] puntos = { new Point(0, 0), new Point(panel1.Width, 0), new Point(panel1.Width, panel1.Height), new Point(0, panel1.Height) };
            gp.FillPolygon(brocha, puntos);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Brush brocha = new SolidBrush(Color.Lime);
            Pen pen = new Pen(brocha);
            Point[] puntos = new Point[panel1.Height * 2];
            for (int i = 0; i < panel1.Height / 2; i++)
            {
                puntos[i * 4] = new Point(i - 1, i);
                puntos[i * 4 + 1] = new Point(panel1.Width - (i + 3), i);
                puntos[i * 4 + 2] = new Point(panel1.Width - (i + 3), panel1.Height - (i + 3));
                puntos[i * 4 + 3] = new Point(i, panel1.Height - (i + 3));
            }

            gp.DrawLines(pen, puntos);
        }
    }
}
