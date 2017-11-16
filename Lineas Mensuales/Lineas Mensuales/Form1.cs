using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lineas_Mensuales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grafico = e.Graphics;
            // Pa las líneas, construyo un pen rojo y otro negro
            Pen penRojo = new Pen(Color.Red, 3);
            // Pa los rellenos, construyo una brocha azul y otra naranja
            Brush brochaAzul = new SolidBrush(Color.Blue);


            int centroX = panel1.Width / 2;
            int centroY = panel1.Height / 2;
            int ciclos = 12;

            Point[] puntos = new Point[panel1.Width];

            for (int i = 0; i < puntos.Length; i++)
            {
                puntos[i].X = i;
                puntos[i].Y = Convert.ToInt32(centroY - (centroY) * Math.Sin(i * ciclos * 2 * Math.PI / panel1.Width));
            }



            grafico.DrawLines(penRojo, puntos);
        }
    }
}
