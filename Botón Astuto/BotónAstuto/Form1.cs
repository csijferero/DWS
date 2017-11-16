using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BotónAstuto
{
    public partial class Form1 : Form
    {
        Point[] puntos = { new Point(266, 250), new Point(77, 280), new Point(200, 200), new Point(408, 250), new Point(466, 105), new Point(200, 200), new Point(77, 280), new Point(40, 111) };
        int posicion = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            btnSi.Visible = false;
            label1.BackColor = System.Drawing.Color.Red;
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label1.Text = "¡Pues Sigue a tu bola!";
        }

        private void btnSi_MouseEnter(object sender, EventArgs e)
        {
            btnSi.Location = new System.Drawing.Point(160, 135);
            posicion++;
            if (posicion == 8)
                posicion = 0;
            
            //posicion = (posicion + 1) % 8;
        }

        private void btnNO_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Coral;
            label1.Text = "¿Quieres que te ponga directamente un 10 en DWS?";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            btnSi.Visible = true;
        }
    }
}
