using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araña
{
    public partial class Form1 : Form
    {
        int xRaton = 0;
        int yRaton = 0;
        public Form1()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grafico = e.Graphics;
            // Pa las líneas, construyo un pen rojo
            Pen penRojo = new Pen(Color.Red, 3);

            Point[] puntos = new Point[34];

            int superior = 0;

            for (int i = 0; i < 10; i += 2)
            {
                puntos[i].X = xRaton;
                puntos[i].Y = yRaton;

                puntos[i + 1].X = ClientSize.Width / 4 * superior;
                puntos[i + 1].Y = 0;

                superior++;
            }

            int derecha = 1;

            for (int i = 10; i < 18; i += 2)
            {
                puntos[i].X = xRaton;
                puntos[i].Y = yRaton;

                puntos[i + 1].X = ClientSize.Width;
                puntos[i + 1].Y = ClientSize.Height / 4 * derecha;

                derecha++;
            }

            int abajo = 3;

            for (int i = 18; i < 26; i += 2)
            {
                puntos[i].X = xRaton;
                puntos[i].Y = yRaton;

                puntos[i + 1].X = ClientSize.Width / 4 * abajo;
                puntos[i + 1].Y = ClientSize.Height;

                abajo--;
            }

            int izquierda = 3;

            for (int i = 26; i < 34; i += 2)
            {
                puntos[i].X = xRaton;
                puntos[i].Y = yRaton;

                puntos[i + 1].X = 0;
                puntos[i + 1].Y = ClientSize.Height / 4 * izquierda;

                izquierda--;
            }

            grafico.DrawLines(penRojo, puntos);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point posRaton = new Point(e.X, e.Y);
            xRaton = posRaton.X;
            yRaton = posRaton.Y;
            Invalidate();
        }
    }
}
