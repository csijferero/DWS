using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColoresyDibujaTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResizeRedraw = true;


        }

        private void MiControladorPaint(object sender, PaintEventArgs e)
        {
            Graphics grfx = e.Graphics;
            string texto = "ClientSizeClientSizeClientSize";
            Font fuente = this.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Brush brocha = new SolidBrush(Color.Black);
            //Random azar = new Random();
            //int r = azar.Next(255),
            //    g = azar.Next(255),
            //    b = azar.Next(255);
            //grfx.Clear(Color.FromArgb(r,g,b));

            float x = ClientSize.Width / 2,
                  y = ClientSize.Height / 2;
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            grfx.DrawString(texto, fuente, brocha, x, y, formato);

            string texto2 = "TL";
            StringFormat formato2 = new StringFormat();
            formato2.Alignment = StringAlignment.Near;
            formato2.LineAlignment = StringAlignment.Near;
            grfx.DrawString(texto2, fuente, brocha, 0, 0, formato2);

            string texto3 = "TR";
            StringFormat formato3 = new StringFormat();
            formato3.Alignment = StringAlignment.Far;
            formato3.LineAlignment = StringAlignment.Near;
            grfx.DrawString(texto3, fuente, brocha, ClientSize.Width, 0, formato3);

            string texto4 = "BL";
            StringFormat formato4 = new StringFormat();
            formato4.Alignment = StringAlignment.Near;
            formato4.LineAlignment = StringAlignment.Far;
            grfx.DrawString(texto4, fuente, brocha, 0, ClientSize.Height, formato4);

            string texto5 = "BR";
            StringFormat formato5 = new StringFormat();
            formato5.Alignment = StringAlignment.Far;
            formato5.LineAlignment = StringAlignment.Far;
            grfx.DrawString(texto5, fuente, brocha, ClientSize.Width, ClientSize.Height, formato5);
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
