using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W11_SenoideWin
{
    public partial class Form2 : Form
    {
        Form1 grafico;
        Graphics grfx2;
        Color colorFondo;

        public Form2()
        {
            InitializeComponent();
            //Creo el grafico para el panel
            grfx2 = panelDibujo2.CreateGraphics();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            grafico = ((Form1)(this.Owner)).Senoide;
            colorFondo = ((Form1)(this.Owner)).Color;

        }

        private void panelDibujo2_Paint(object sender, PaintEventArgs e)
        {
            panelDibujo2.BackColor = colorFondo;
            grfx2.DrawLines(grafico.Pen, grafico.Puntos);
            grfx2.DrawLine(grafico.Pen, 0, panelDibujo2.Height / 2, panelDibujo2.Width, panelDibujo2.Height / 2);

        }
    }
}
