﻿using System;
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
    public partial class Form1 : Form
    {
        Graphics grfx;
        Pen pen;
        Point[] puntos;
        Form1 senoide;
        Color color;

        public Form1 Senoide
        {
            get
            {
                return senoide;
            }

            set
            {
                senoide = value;
            }
        }

        public Pen Pen
        {
            get
            {
                return pen;
            }

            set
            {
                pen = value;
            }
        }

        public Point[] Puntos
        {
            get
            {
                return puntos;
            }

            set
            {
                puntos = value;
            }
        }

        public Color Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Pen pen, Point[] puntos)
        {
            this.pen = pen;
            this.puntos = puntos;
        }

        

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            
            // Pa las líneas, construyo un pen rojo y otro negro
            pen = new Pen(lbColorTrazo.BackColor, Convert.ToInt32(cbGrosor.SelectedItem));
            // Pa los rellenos, construyo una brocha azul y otra naranja
            Brush brocha = new SolidBrush(Color.Blue);


            int centroY = panelDibujo.Height / 2;
            double ciclos = (double)nudCiclos.Value;

            puntos = new Point[panelDibujo.Width];

            for (int i = 0; i < puntos.Length; i++)
            {
                puntos[i].X = i;
                puntos[i].Y = Convert.ToInt32(centroY - (int)nudOffset.Value - (trkbAmplitud.Value) * Math.Sin((Math.PI * (int)nudDesfase.Value / 180) + i * ciclos * 2 * Math.PI / panelDibujo.Width));
            }

            senoide = new Form1(pen, puntos);

            //... Construyo el formulario "receptor" form2
            Form2 form2 = new Form2();
            // Hago que éste sea su propietario
            form2.Owner = this;

            //--- Lo que sigue va a ser igual para todos los casos---
            // Lo lanzamos como diálogo de éste
            DialogResult dialogo = form2.ShowDialog();

            //grfx.DrawLines(pen, puntos);
            //grfx.DrawLine(pen, 0, panelDibujo.Height / 2, panelDibujo.Width, panelDibujo.Height / 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Creo el grafico para el panel
            grfx = panelDibujo.CreateGraphics();
            //Establezco maxima amplitud para el trackBar
            trkbAmplitud.Maximum = panelDibujo.Height / 2;
            //Relleno y selecciono un grosor del combo
            for (double i = 1; i <= 5; i += 0.5)
            {
                cbGrosor.Items.Add(i);
            }
            cbGrosor.SelectedItem = 2.5;
            //Blanco chequeado al iniciar
            rbBlanco.Checked = true;

        }

        //Valor de la etiqueta del trackBar
        private void trkbAmplitud_Scroll(object sender, EventArgs e)
        {
            lbAmplitud.Text = Convert.ToString(trkbAmplitud.Value);
            lbAmplitud.Location = new Point(lbAmplitud.Location.X, 228 - (int)(trkbAmplitud.Value * 0.82));
        }

        private void lbColorTrazo_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == colorDialog1.ShowDialog())
            {
                lbColorTrazo.BackColor = colorDialog1.Color;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
//            grfx.Clear(Form1.DefaultBackColor);
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            color = rbBlanco.BackColor;
            if (rbBlanco.Checked)
                color = rbBlanco.BackColor;
            else if (rbNegro.Checked)
                color = rbNegro.BackColor;
            else if (rbRojo.Checked)
                color = rbRojo.BackColor;
            else if (rbVerde.Checked)
                color = rbVerde.BackColor;
            else if (rbAzul.Checked)
                color = rbAzul.BackColor;

            panelDibujo.BackColor = color;
        }
    }
}
