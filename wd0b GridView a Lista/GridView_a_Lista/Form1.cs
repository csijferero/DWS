using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace GridView_a_Lista
{
    public partial class Form1 : Form
    {
        List<Equipo> listaEquipos = new List<Equipo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
                MessageBox.Show("El equipo seleccionado es: " + dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), "Seleccion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (e.RowIndex >= 0 && e.ColumnIndex == 1)
                MessageBox.Show("Los partidos jugados de " + dgv.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString() + " son " + dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), "Seleccion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (e.RowIndex >= 0 && e.ColumnIndex == 2)
                MessageBox.Show("Los partidos ganados de " + dgv.Rows[e.RowIndex].Cells[e.ColumnIndex - 2].Value.ToString() + " son " + dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), "Seleccion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (e.RowIndex >= 0 && e.ColumnIndex == 3)
                MessageBox.Show("Los partidos empatados de " + dgv.Rows[e.RowIndex].Cells[e.ColumnIndex - 3].Value.ToString() + " son " + dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), "Seleccion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (e.RowIndex >= 0 && e.ColumnIndex == 4)
                MessageBox.Show("Los partidos perdidos de " + dgv.Rows[e.RowIndex].Cells[e.ColumnIndex - 4].Value.ToString() + " son " + dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), "Seleccion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (e.RowIndex >= 0 && e.ColumnIndex == 5)
                MessageBox.Show("Los goles a favor de " + dgv.Rows[e.RowIndex].Cells[e.ColumnIndex - 5].Value.ToString() + " son " + dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), "Seleccion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (e.RowIndex >= 0 && e.ColumnIndex == 6)
                MessageBox.Show("Los goles en contra de " + dgv.Rows[e.RowIndex].Cells[e.ColumnIndex - 6].Value.ToString() + " son " + dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), "Seleccion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCargarFichero_Click(object sender, EventArgs e)
        {
            string line;
            listaEquipos.Clear();
            Stream myStream = null;
            StreamReader file = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    try { 
                    clbAnadidos.Items.Clear();
                    file = new StreamReader(openFileDialog1.FileName, Encoding.Default);
                    while ((line = file.ReadLine()) != null)
                    {
                        Equipo equipo = new Equipo(line);

                        clbAnadidos.Items.Add(CuadraTexto(equipo));
                        listaEquipos.Add(equipo);
                    }
                    file.Close();
                    dgv.DataSource = null;
                    dgv.DataSource = listaEquipos;
                    }
                    catch
                    {
                        file.Close();
                        MessageBox.Show("ERROR DE FORMATO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private string CuadraTexto(Equipo equipo)
        {
            string nombre = equipo.Nombre;
            for (int i = equipo.Nombre.Length; i < 13; i++)
            {
                nombre += " ";
            }
            return (nombre + "\t" + equipo.Puntos.ToString("D2") + ";" + equipo.Pg.ToString("D2") + ";" + equipo.Pe.ToString("D2") + ";" + equipo.Pp.ToString("D2") + ";" + equipo.Gf.ToString("D2") + ";" + equipo.Gc.ToString("D2"));
        }
    }
}
