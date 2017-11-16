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

namespace PW7b_CheckedList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && !listaEquipos.Items.Contains(textBox1.Text))
                listaEquipos.Items.Add(textBox1.Text);
            else
                MessageBox.Show("**Introduzca un Equipo nuevo y valido**", "ERROR");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listaEquipos.Items.Count; i++)
            {
                if (listaEquipos.GetItemChecked(i))
                {
                    listaEquipos.Items.RemoveAt(i);
                    i--;
                }
            }
            for (int i = 0; i < lista2.Items.Count; i++)
            {
                if (lista2.GetItemChecked(i))
                {
                    lista2.Items.RemoveAt(i);
                    i--;
                }
            }
        }

        private void checkedChanged(object sender, EventArgs e)
        {
            if (rb1.Checked)
            {
                listaEquipos.CheckOnClick = true;
                lista2.CheckOnClick = true;
            }
            else
            {
                listaEquipos.CheckOnClick = false;
                lista2.CheckOnClick = false;
            }

        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listaEquipos.Items.Count; i++)
            {
                if (listaEquipos.GetItemChecked(i))
                    listaEquipos.SetItemChecked(i, false);
                else
                    listaEquipos.SetItemChecked(i, true);
            }
        }

        private void chbOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOrden.Checked)
            {
                listaEquipos.Sorted = true;
                lista2.Sorted = true;
            }
            else
            {
                listaEquipos.Sorted = false;
                lista2.Sorted = false;
            }
        }

        private void chbMulti_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMulti.Checked)
            {
                listaEquipos.MultiColumn = true;
                lista2.MultiColumn = true;
            }
            else
            {
                listaEquipos.MultiColumn = false;
                lista2.MultiColumn = false;
            }
        }

        private void rdbIzq_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDer.Checked)
            {
                listaEquipos.RightToLeft = RightToLeft.Yes;
                lista2.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                listaEquipos.RightToLeft = RightToLeft.No;
                lista2.RightToLeft = RightToLeft.No;
            }

        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listaEquipos.Items.Count; i++)
            {
                if (!listaEquipos.GetItemChecked(i))
                    listaEquipos.SetItemChecked(i, true);
            }
        }

        private void btnExtra_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listaEquipos.Items.Count; i++)
            {
                if (listaEquipos.GetItemChecked(i))
                {
                    lista2.Items.Add(listaEquipos.Items[i]);
                    listaEquipos.Items.RemoveAt(i);
                    i--;
                }
            }
        }

        private void btnTodo2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lista2.Items.Count; i++)
            {
                if (!lista2.GetItemChecked(i))
                    lista2.SetItemChecked(i, true);
            }
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            string line;
            int contadorRep = 0;
            int contador = 0;
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    StreamReader file = new StreamReader(openFileDialog1.FileName);
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] table = line.Split(';');
                        if (!listaEquipos.Items.Contains(table[0]))
                        {
                            listaEquipos.Items.Add(table[0]);
                            contador++;
                        }
                        else
                            contadorRep++;
                    }

                    file.Close();
                }

            }
            MessageBox.Show("Agregados: " + contador + "\nNo Agregados: " + contadorRep, "Resultados");
        }
    }
}
