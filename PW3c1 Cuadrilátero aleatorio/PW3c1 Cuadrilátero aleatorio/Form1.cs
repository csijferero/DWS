using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PW3c1_Cuadrilátero_aleatorio
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

            Font drawFont = new Font("Arial", 16);

            Graphics grafico = e.Graphics;
            // Pa las líneas, construyo un pen rojo y otro negro
            Pen penRojo = new Pen(Color.Red, 3);
            // Pa los rellenos, construyo una brocha azul y otra naranja
            Brush brochaAzul = new SolidBrush(Color.Blue);
            // Fijo los márgenes en función del tamaño del formulario
            int margenX = ClientSize.Width / 10, margenY = ClientSize.Height / 10,
                xIzquierda = margenX, xDerecha = ClientSize.Width - margenX,
                ySuperior = margenY, yInferior = ClientSize.Height - margenY,
                ancho = ClientSize.Width - 2 * margenX, alto = ClientSize.Height - 2 * margenY;

            Random generator = new Random();

            int tlX = generator.Next(xIzquierda, ClientSize.Width - xIzquierda);
            int tlY = generator.Next(ySuperior, ClientSize.Height - ySuperior);
            int trX = generator.Next(xIzquierda, ClientSize.Width - xIzquierda);
            int trY = generator.Next(ySuperior, ClientSize.Height - ySuperior);
            int blX = generator.Next(xIzquierda, ClientSize.Width - xIzquierda);
            int blY = generator.Next(ySuperior, ClientSize.Height - ySuperior);
            int brX = generator.Next(xIzquierda, ClientSize.Width - xIzquierda);
            int brY = generator.Next(ySuperior, ClientSize.Height - ySuperior);

            Point[] puntos = {new Point(tlX , tlY),
                                new Point(trX, trY),
                                new Point(blX, blY),
                                new Point(brX, brY)
                                };

            grafico.DrawPolygon(penRojo, puntos);

            grafico.DrawString("(" + tlX + "," + tlY + ")", drawFont, brochaAzul, tlX, tlY);
            grafico.DrawString("(" + trX + "," + trY + ")", drawFont, brochaAzul, trX, trY);
            grafico.DrawString("(" + blX + "," + blY + ")", drawFont, brochaAzul, blX, blY);
            grafico.DrawString("(" + brX + "," + brY + ")", drawFont, brochaAzul, brX, brY);

        }
    }
}
