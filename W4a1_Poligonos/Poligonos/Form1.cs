using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// El siguiente espacio de nombres es necesario para usar FillMode
using System.Drawing.Drawing2D;

namespace Poligonos
{
    public partial class Form1 : Form
    {
        int numVertices = 5;
        public Form1()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grafico = e.Graphics;
            // Pa las líneas, construyo un pen  negro de grosor 3
            Pen penNegro = new Pen(Color.Black, 3);
            // Pa los rellenos, construyo una brocha azul
            Brush brochaAzul = new SolidBrush(Color.Blue);

            Point[] tablaPuntos = new Point[numVertices];
            Point centro = new Point(ClientSize.Width / 2, ClientSize.Height / 2);

            int margenX = ClientSize.Width / 20, margenY = ClientSize.Height / 20;
            int ancho = ClientSize.Width - 2 * margenX, alto = ClientSize.Height - 2 * margenY;


            double anguloBase = 2 * Math.PI / numVertices; // <-- Así tenemos el ángulo directamente en radianes
            int radio;
            // Para no salirnos tomamos el radio con el mínimo entre el ancho y el alto
            if (ancho < alto)
                radio = ancho / 2;
            else
                radio = alto / 2;

            for (int i = 0; i < tablaPuntos.Length; i++)
            {
                tablaPuntos[i].X = centro.X + (int)(radio * Math.Cos(i * anguloBase));
                tablaPuntos[i].Y = centro.Y + (int)(radio * Math.Sin(i * anguloBase));
                //Nota: si el número de vértices es impar, basta con multiplicar el ángulo por 2 para que salga una estrella
            }


            // Dibujo o relleno según el ancho y alto de la zona del cliente
            if (ClientSize.Width<ClientSize.Height)
                grafico.DrawPolygon(penNegro, tablaPuntos);
            else
                grafico.FillPolygon(brochaAzul, tablaPuntos);
                // En caso de dibujar una estrella, sustituye la anterior por esta y comprueba la diferencia
                // grafico.FillPolygon(brochaAzul, tablaPuntos, FillMode.Alternate);
        }
    }
}
