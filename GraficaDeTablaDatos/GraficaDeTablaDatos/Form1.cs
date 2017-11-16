using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraficaDeTablaDatos
{
    public partial class Form1 : Form
    {
        int ancho, alto;
        int numPuntos=10, segmentoX;
        Point[] tabPuntos;
        Graphics grfx;
        Font fuenteTexto;
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            tabPuntos = new Point[numPuntos];
            segmentoX = ancho / (numPuntos); 
            Random azar = new Random();
            Point punto;
            listbPuntos.Items.Clear(); //<-- Limpiamos la lista de datos
            for (int i = 0; i < tabPuntos.Length; i++)
            {
                punto= new Point(i * segmentoX, azar.Next(alto));
                
                listbPuntos.Items.Add(String.Format("{2} - ({0}, {1})", punto.X, punto.Y, i+1));

                tabPuntos[i] = new Point(punto.X, alto - punto.Y);
            }

            Pen pen = new Pen(Color.Black, 3);
            //Graphics grfx = panelDibujo.CreateGraphics();

            grfx.Clear(Color.Lime); // Limpiamos antes de dibujar


            // Pintamos las lineas verticales, para cada x
            grfx.DrawLine(new Pen(Color.Black), 0, 0, 0, alto); // <-- Eje Y
                                                                //grfx.DrawLine(new Pen(Color.Black), 0, 0, 0, alto); // <-- Eje X

            foreach (Point p in tabPuntos)
            {
                grfx.DrawLine(new Pen(Color.Red), p.X, alto, p.X, p.Y);
            }
            grfx.DrawLines(pen, tabPuntos);
            //// Pintamos las coordenadas de cada punto

            //foreach (Point p in tabPuntos)
            //{
            //    grfx.DrawString(String.Format("({0}, {1})", p.X, alto - p.Y), fuenteTexto, Brushes.Black, p);
            //}
            ////     grfx.DrawString(p.ToString(), this.Font, Brushes.Black, p);

            

            

        }

        private void listbPuntos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Point p = tabPuntos[listbPuntos.SelectedIndex];
            grfx.Clear(Color.Lime); // Limpiamos antes de dibujar


            grfx.DrawLine(new Pen(Color.Black), 0, 0, 0, alto); // <-- Eje Y
            //grfx.DrawLine(new Pen(Color.Black), 0, 0, 0, alto); // <-- Eje X
            Pen pen = new Pen(Color.Black, 3);
            grfx.DrawLines(pen, tabPuntos);
            grfx.DrawString(String.Format("({0}, {1})", p.X, alto - p.Y), fuenteTexto, Brushes.Black, p);
            grfx.FillEllipse(Brushes.Red, p.X - 5, p.Y - 5, 10, 10); // <-- Dibujo un círculo centrado en el punto a marcar

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ancho = panelDibujo.Width;
            alto = panelDibujo.Height;
            grfx = panelDibujo.CreateGraphics();

            fuenteTexto = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
        }
    }
}
