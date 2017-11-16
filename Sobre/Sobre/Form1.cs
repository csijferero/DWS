using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sobre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grafico = e.Graphics;
            // Pa las líneas, construyo un pen rojo y otro negro
            Pen penRojo = new Pen(Color.Red, 3);
            // Pa los rellenos, construyo una brocha azul y otra naranja
            Brush brochaAzul = new SolidBrush(Color.Blue);
            // Fijo los márgenes en función del tamaño del formulario
            int margenX = ClientSize.Width / 10, margenY = ClientSize.Height / 10,
                xIzquierda = margenX, xDerecha = ClientSize.Width - margenX,
                ySuperior = margenY*3, yInferior = ClientSize.Height - margenY,
                ancho = ClientSize.Width - 2 * margenX, alto = ClientSize.Height - 2 * margenY;

            Point[] puntos = {new Point(xIzquierda, yInferior),
                                new Point(xIzquierda, ySuperior),
                                new Point(xDerecha, ySuperior),
                                new Point(xIzquierda, yInferior),
                                new Point(xDerecha, yInferior),
                                new Point(xIzquierda, ySuperior),
                                new Point(ClientSize.Width/2, ySuperior/4),
                                new Point(xDerecha, ySuperior),
                                new Point(xDerecha, yInferior)
                                };
            grafico.DrawLines(penRojo, puntos);
        }
    }
}