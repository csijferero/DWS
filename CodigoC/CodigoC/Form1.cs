using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodigoC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            bool repe = false;
            List<string> lista = new List<string>(); //Lista para comprobar valores repetidos
            bool correcto = false; // Informará de si existen errores

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                //Comprobamos si hay valores vacios
                if (boxClase.Text != "" && dataGridView1.Rows[i].Cells[0].Value != null && dataGridView1.Rows[i].Cells[1].Value != null) //Si NO hay vacios...
                {
                    correcto = true;
                    lista.Add(dataGridView1.Rows[i].Cells[1].Value.ToString()); //Añado a la lista
                }
                else // Si hay vacios...
                {
                    correcto = false; // Da error
                    break;
                }
            }

            //Comprobamos si hay valores repetidos en la lista
            if (correcto)
            {
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    int contador = 0; //Contador para ver si hay valores repetidos en la lista
                    for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[1].Value.ToString() == lista[j]) //Si existe en la lista...
                        {
                            contador++; // Sumo 1
                        }
                    }
                    //Si hay valores repetidos damos error
                    if (contador >= 2) // Si hay 2 o mas...
                    {
                        repe = true;
                        correcto = false; // Da error
                        break;
                    }
                }
            }

            if (!correcto)
            {
                string textError = "";
                if (boxClase.Text == "")
                    textError = "El nombre de la clase esta vacio\n ";
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value == null)
                        textError += "El tipo en la fila " + (i + 1).ToString("D1") + " no ha sido seleccionado\n";
                    if (dataGridView1.Rows[i].Cells[1].Value == null)
                        textError += "El nombre en la fila " + (i + 1).ToString("D1") + " no ha sido seleccionado\n";
                }
                if (dataGridView1.RowCount<=1)
                    textError += "No se han añadido parametros";
                if (repe)
                    textError += "Hay parámetros repetidos";
                MessageBox.Show(textError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            else
            {
                textBox.Text = "public class " + boxClase.Text.ToString()[0].ToString().ToUpper() + boxClase.Text.Substring(1) + " {\n\n";
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    textBox.Text += dataGridView1.Rows[i].Cells[0].Value;
                    textBox.Text += " " + dataGridView1.Rows[i].Cells[1].Value + ";\n";
                }
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[2].Value) || Convert.ToBoolean(dataGridView1.Rows[i].Cells[3].Value))
                    {
                        textBox.Text += "\n\tpublic " + dataGridView1.Rows[i].Cells[0].Value + " " + dataGridView1.Rows[i].Cells[1].Value.ToString()[0].ToString().ToUpper() + dataGridView1.Rows[i].Cells[1].Value.ToString().Substring(1) + "\n\t{\n";
                        if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[2].Value))
                            textBox.Text += "\t\tget\n\t\t{\n\t\t\treturn " + dataGridView1.Rows[i].Cells[1].Value + ";\n\t\t}";
                        if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[3].Value))
                            textBox.Text += "\n\t\tset\n\t\t{\n\t\t\t" + dataGridView1.Rows[i].Cells[1].Value + "=" + "value;\n\t\t}";
                        textBox.Text += "\n\t}";
                    }
                }
                textBox.Text += "\n}";
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }
    }
}
