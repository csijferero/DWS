using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W2_Fernández_JoséAntonio
{
    public partial class Form1 : Form
    {
        Random generator = new Random();

        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Minimum = -panel1.Height / 2;
            numericUpDown2.Minimum = -panel1.Height / 2;
            numericUpDown1.Maximum = panel1.Height / 2;
            numericUpDown2.Maximum = panel1.Height / 2;
            ResizeRedraw = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            numericUpDown1.Maximum = numericUpDown2.Value;
            numericUpDown2.Minimum = numericUpDown1.Value;
            Graphics grafico = e.Graphics;
            // Pa las líneas, construyo un pen rojo y otro negro
            Pen penRojo = new Pen(Color.Red, 3);
            Pen penNegro = new Pen(Color.Black, 1);
            Pen penAmarillo = new Pen(Color.Yellow, 1);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Font drawFont = new Font("Arial", 10);

            int mitadAltura = panel1.Height / 2;

            Point[] puntos = new Point[(int)numericUpDown3.Value];

            for (int i = 0; i < puntos.Length; i++)
            {
                puntos[i].X = (panel1.Width - 15) / ((int)numericUpDown3.Value - 1) * i;
                grafico.DrawLine(penNegro, ((panel1.Width - 15) / ((int)numericUpDown3.Value - 1) * i), 0, ((panel1.Width - 15) / ((int)numericUpDown3.Value - 1) * i), panel1.Height); //Eje Vertical
                grafico.DrawString((i + 1).ToString(), drawFont, drawBrush, ((panel1.Width - 15) / ((int)numericUpDown3.Value - 1) * i), mitadAltura + 5); //Valor del Eje Vertical

                puntos[i].Y = generator.Next(mitadAltura - (int)numericUpDown2.Value, mitadAltura - (int)numericUpDown1.Value);
            }

            grafico.DrawLine(penNegro, 0, panel1.Height / 2, (int)(((panel1.Width - 15) / ((int)numericUpDown3.Value - 1)) * (numericUpDown3.Value - 1)), panel1.Height / 2); //EjeCoordenadas
            grafico.DrawLine(penAmarillo, 0, mitadAltura - (int)numericUpDown2.Value, (int)(((panel1.Width - 15) / ((int)numericUpDown3.Value - 1)) * (numericUpDown3.Value - 1)), mitadAltura - (int)numericUpDown2.Value); //EjeMaximo
            grafico.DrawLine(penAmarillo, 0, mitadAltura - (int)numericUpDown1.Value, (int)(((panel1.Width - 15) / ((int)numericUpDown3.Value - 1)) * (numericUpDown3.Value - 1)), mitadAltura - (int)numericUpDown1.Value); //EjeMinimo
            grafico.DrawLines(penRojo, puntos); //Grafica

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }
    }
}
