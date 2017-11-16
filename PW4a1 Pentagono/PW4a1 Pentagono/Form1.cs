using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PW4a1_Pentagono
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

            Point[] puntos = new Point[5];
            Point centro = new Point(ClientSize.Width / 2, ClientSize.Height / 2);

            int margenX = ClientSize.Width / 20;
            int margenY = ClientSize.Height / 20;
            int ancho = ClientSize.Width - margenX * 2;
            int alto = ClientSize.Height - margenY * 2;


            double anguloBase = 2 * Math.PI / 5; // <--Angulo directamente en radianes
            double radio;
            if (ancho < alto)
                radio = ancho / 2;
            else
                radio = alto / 2;


            for (int i = 0; i < puntos.Length; i++)
            {
                puntos[i].X = centro.X + Convert.ToInt32(radio * Math.Cos(i * anguloBase));
                puntos[i].Y = centro.Y + Convert.ToInt32(radio * Math.Sin(i * anguloBase));
            }


            if (ClientSize.Width > ClientSize.Height)
                grafico.FillPolygon(brochaAzul, puntos);
            else
                grafico.DrawPolygon(penRojo, puntos);



        }
    }
}
