using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPoligonosReg
{
    public partial class FormDibujo : Form
    {

        Graphics grfx;

        public FormDibujo()
        {
            InitializeComponent();
        }

        private void FormDibujo_Load(object sender, EventArgs e)
        {
            grfx = panelDibujo.CreateGraphics();
            for (double i = 1; i <= 4; i += 0.5)
            {
                cbGrosor.Items.Add(i);
            }
            cbGrosor.SelectedItem = 2.0;
            rbNegro.Checked = true;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {

            if (DialogResult.OK == colorDialog.ShowDialog())
            {
                lbColor.BackColor = colorDialog.Color;
            }

            if (rbNegro.Checked)
                rbNegro.Checked = false;
            else if (rbRojo.Checked)
                rbRojo.Checked = false;
            else if (rbVerde.Checked)
                rbVerde.Checked = false;
            else if (rbAzul.Checked)
                rbAzul.Checked = false;
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            bool check = false;
            Color color = Color.Black;
            if (rbNegro.Checked)
            {
                color = Color.Black;
                check = true;
            }
            else if (rbRojo.Checked)
            {
                color = Color.Red;
                check = true;
            }
            else if (rbVerde.Checked)
            {
                color = Color.Green;
                check = true;
            }
            else if (rbAzul.Checked)
            {
                color = Color.Blue;
                check = true;
            }

            if (check)
                lbColor.BackColor = color;
        }

        private void track_ValueChanged(object sender, EventArgs e)
        {
            lbCoord.Text = "(" + Convert.ToString(trackX.Value) + ", " + Convert.ToString(500 - trackY.Value) + ")";

        }

        private void trackRadio_ValueChanged(object sender, EventArgs e)
        {
            txtRadio.Text = Convert.ToString(trackRadio.Value);
        }

        private void txtRadio_TextChanged(object sender, EventArgs e)
        {
            int numero;
            if (!Int32.TryParse(txtRadio.Text, out numero))
            {
                MessageBox.Show("** Solo valores numericos **", "ERROR");
                txtRadio.Text = "0";
            }
            else if (numero < 0 || numero > 250)
            {
                MessageBox.Show("** Solo valores entre 0 y 250 **", "ERROR");
                txtRadio.Text = "0";
            }
            else
                trackRadio.Value = Convert.ToInt32(txtRadio.Text);
        }

        private void panelDibujo_MouseClick(object sender, MouseEventArgs e)
        {
            trackY.Value = 500 - e.Y;
            trackX.Value = e.X;
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            Color color = lbColor.BackColor;
            Pen pen = new Pen(color, Convert.ToSingle(cbGrosor.Text));

            Point[] tablaPuntos = new Point[(int)nudNumLados.Value];
            Point centro = new Point(trackX.Value, 500 - trackY.Value);



            double anguloBase = 2 * Math.PI / (int)nudNumLados.Value;
            int radio = trackRadio.Value;

            for (int i = 0; i < tablaPuntos.Length; i++)
            {
                tablaPuntos[i].X = centro.X + (int)(radio * Math.Cos(trackGiro.Value * Math.PI / 180 + i * anguloBase));
                tablaPuntos[i].Y = centro.Y + (int)(radio * Math.Sin(trackGiro.Value * Math.PI / 180 + i * anguloBase));
            }
            grfx.DrawPolygon(pen, tablaPuntos);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere borrar el panel?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                grfx.Clear(Color.White);
        }

        private void btnRellenar_Click(object sender, EventArgs e)
        {
            Color color = lbColor.BackColor;
            SolidBrush brocha = new SolidBrush(color);

            Point[] tablaPuntos = new Point[(int)nudNumLados.Value];
            Point centro = new Point(trackX.Value, 500 - trackY.Value);



            double anguloBase = 2 * Math.PI / (int)nudNumLados.Value;
            int radio = trackRadio.Value;

            for (int i = 0; i < tablaPuntos.Length; i++)
            {
                tablaPuntos[i].X = centro.X + (int)(radio * Math.Cos(trackGiro.Value * Math.PI / 180 + i * anguloBase));
                tablaPuntos[i].Y = centro.Y + (int)(radio * Math.Sin(trackGiro.Value * Math.PI / 180 + i * anguloBase));
            }
            grfx.FillPolygon(brocha, tablaPuntos);
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Color color = lbColor.BackColor;
            Pen pen = new Pen(color, Convert.ToSingle(cbGrosor.Text));

            Point[] tablaPuntos = new Point[(int)nudNumLados.Value];
            Point centro = new Point(trackX.Value, 500 - trackY.Value);



            double anguloBase = 2 * Math.PI / (int)nudNumLados.Value;
            int radio = trackRadio.Value;

            for (int i = 0; i < tablaPuntos.Length; i++)
            {
                tablaPuntos[i].X = centro.X + (int)(radio * Math.Cos(trackGiro.Value * Math.PI / 180 + i * anguloBase));
                tablaPuntos[i].Y = centro.Y + (int)(radio * Math.Sin(trackGiro.Value * Math.PI / 180 + i * anguloBase));
            }

            for (int i = 0; i < tablaPuntos.Length; i++)
            {
                for (int j = 0; j < tablaPuntos.Length; j++)
                {
                    grfx.DrawLine(pen, tablaPuntos[i], tablaPuntos[j]);
                }
            }
        }

        private void trackGiro_ValueChanged(object sender, EventArgs e)
        {
            txtGiro.Text = Convert.ToString(trackGiro.Value);
        }

        private void txtGiro_TextChanged(object sender, EventArgs e)
        {
            int numero2;
            if (!Int32.TryParse(txtGiro.Text, out numero2))
            {
                MessageBox.Show("** Solo valores numericos **", "ERROR");
                txtGiro.Text = "0";
            }
            else if (numero2 < 0 || numero2 > 90)
            {
                MessageBox.Show("** Solo valores entre 0 y 90 **", "ERROR");
                txtGiro.Text = "0";
            }
            else
                trackGiro.Value = Convert.ToInt32(txtGiro.Text);
        }
    }
}
