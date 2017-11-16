using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RectanguloRellenable
{
    public partial class Form1 : Form
    {
        bool bRellenar = false;
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
                ySuperior = margenY,  yInferior = ClientSize.Height - margenY, 
                ancho = ClientSize.Width - 2 * margenX, alto = ClientSize.Height - 2 * margenY;

            #region Versión 0 MBP línea a línea
            //// Versión MBP
            //Point pSupIz = new Point(xIzquierda, ySuperior);
            //Point pSupde = new Point(xDerecha, ySuperior);
            //Point pInfIz = new Point(xIzquierda, yInferior);
            //Point pInfDe = new Point(xDerecha, yInferior);

            //grafico.DrawLine(penRojo, pSupIz, pSupde); // Esta es la línea superior
            //grafico.DrawLine(penRojo, pSupde, pInfDe); // Esta es la línea derecha
            //grafico.DrawLine(penRojo, pInfDe, pInfIz); // Esta es la línea inferior
            //grafico.DrawLine(penRojo, pInfIz, pSupIz); // Esta es la línea izquierda
            #endregion

            #region  Versión 1 Polilína
            //Point[] tabPuntos = {new Point(xIzquierda, ySuperior),
            //                    new Point(xDerecha, ySuperior),
            //                    new Point(xDerecha, yInferior),
            //                    new Point(xIzquierda, yInferior)
            //                    };

            ////grafico.DrawLines(penRojo, tabPuntos); // Dibujaría sin unir el último con el primero
            //grafico.DrawPolygon(penRojo, tabPuntos);

            #endregion

            #region Versión con el rectángulo
            // Construyo un rectángulo que voy a usar casi para todo
            Rectangle rect = new Rectangle(xIzquierda, ySuperior, ancho, alto);

            if (bRellenar)
                grafico.FillRectangle(brochaAzul, rect);
            // dibujo el borde en cualquier caso
            grafico.DrawRectangle(penRojo, rect);
            #endregion
        }

        private void btnRellenar_Click(object sender, EventArgs e)
        {
            bRellenar = !bRellenar; // cambiamos de true a false o viceversa

            if (bRellenar)
                btnRellenar.Text = "Vaciar";
            else
                btnRellenar.Text = "Rellenar";
            
            Invalidate();   // Esto llamará invalida el formulario provocando el evento Paint
        }
    }
}
