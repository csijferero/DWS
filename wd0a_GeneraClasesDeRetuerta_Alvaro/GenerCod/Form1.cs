using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerCod
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoSize = true;
            dataGridView1.RowTemplate.Height = 15;
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            if (HayError())
                return;

            richtxt.Text = ("public class " + txt_nombre.Text + "{");
            richtxt.AppendText("\n\n");
            string campo = "";
            richtxt.AppendText("//Atributos\n");
            for (int i = 0; i < dataGrid.Rows.Count - 1; i++)
            {

                campo = dataGrid.Rows[i].Cells[0].Value + " " + dataGrid.Rows[i].Cells[1].Value;

                richtxt.AppendText("\t" + campo + ";\n");
            }
            richtxt.AppendText("//Constructor\n");
            richtxt.AppendText("\n\npublic " + txt_nombre.Text + "(");
            for (int i = 0; i < dataGrid.Rows.Count - 1; i++)
            {
                if (i != 0)
                    richtxt.AppendText(", ");
                richtxt.AppendText("" + dataGrid.Rows[i].Cells[0].Value + " " + dataGrid.Rows[i].Cells[1].Value);
            }
            richtxt.AppendText(") {\n");

            for (int i = 0; i < dataGrid.Rows.Count - 1; i++)
            {
                richtxt.AppendText("\tthis." + dataGrid.Rows[i].Cells[1].Value + "=" + dataGrid.Rows[i].Cells[1].Value + ";\n");
            }
            richtxt.AppendText("}\n");

            richtxt.AppendText("\n//Propiedades\n");

            for (int i = 0; i < dataGrid.Rows.Count - 1; i++)
            {
                string propiedad = "" + dataGrid.Rows[i].Cells[1].Value;
                if (Convert.ToBoolean(dataGrid.Rows[i].Cells[2].Value) && Convert.ToBoolean(dataGrid.Rows[i].Cells[3].Value))
                {

                    richtxt.AppendText("public " + dataGrid.Rows[i].Cells[0].Value + " " + propiedad.Substring(0, 1).ToUpper() + propiedad.Substring(1) + "{");
                    richtxt.AppendText("\n\t get { return " + propiedad + "; }");
                    richtxt.AppendText("\n\t set {" + propiedad + "= value; }");
                    richtxt.AppendText("\n}\n");
                }
                else if (Convert.ToBoolean(dataGrid.Rows[i].Cells[2].Value))//solo get
                {
                    richtxt.AppendText("public " + dataGrid.Rows[i].Cells[0].Value + " " + propiedad.Substring(0, 1).ToUpper() + propiedad.Substring(1) + "{");
                    richtxt.AppendText("\n\t get { return " + propiedad + "; }");
                    richtxt.AppendText("\n}\n");
                }
                else if (Convert.ToBoolean(dataGrid.Rows[i].Cells[3].Value))//solo set
                {
                    richtxt.AppendText("public " + dataGrid.Rows[i].Cells[0].Value + " " + propiedad.Substring(0, 1).ToUpper() + propiedad.Substring(1) + "{");
                    richtxt.AppendText("\n\t set {" + propiedad + "= value; }");
                    richtxt.AppendText("\n}\n");
                }
            }
            richtxt.AppendText("\n}");
            richtxt.Height = richtxt.Lines.Length * 16;
            dataGridView1.Rows.Clear();
            for (int i = 0; i < richtxt.Lines.Length; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = Convert.ToInt32(i+1);
            }
        }

        private bool HayError()
        {
            List<string> listaNombres = new List<string>();
            string mesnsajeError = String.Empty;
            bool hayError = false;

            string nombreClase = txt_nombre.Text.Trim();
            string tipoCampo = String.Empty, nombreCampo = String.Empty;
            if (nombreClase.Length < 1)
            {
                mesnsajeError += "Debe escribir un nombre para la clase\n";
                hayError = true;
            }
            else if (nombreClase[0] != '_' && (nombreClase[0] < 'A' || nombreClase[0] > 'Z'))
            {
                mesnsajeError += "El nombre de la clase no comienza por un carácter válido\n";
                hayError = true;
            }

            for (int i = 0; i < dataGrid.Rows.Count - 1; i++)
            {
                if (dataGrid.Rows[i].Cells[0].Value != null)
                    tipoCampo = dataGrid.Rows[i].Cells[0].Value.ToString();
                else
                    tipoCampo = "";
                if (dataGrid.Rows[i].Cells[1].Value != null)
                    nombreCampo = dataGrid.Rows[i].Cells[1].Value.ToString();

                else
                    nombreCampo = "";

                if (tipoCampo.Length < 1)
                {
                    mesnsajeError += "\nFalta el tipo en el registro " + i;
                    hayError = true;
                }


                if (nombreCampo.Length < 1)
                {
                    mesnsajeError += "\nFalta el nombre del campo en el registro " + i;
                    hayError = true;
                }
                else if (nombreCampo[0] != '_' && (nombreCampo[0] < 'a' || nombreCampo[0] > 'z'))
                {
                    mesnsajeError += "\nEl nombre del campo del registro " + i + " no comienza por un carácter válido";
                    hayError = true;
                }
                else if (listaNombres.Contains(nombreCampo))
                {
                    mesnsajeError += "\nEl nombre del campo del registro " + i + " está repetido";
                    hayError = true;
                }
                else
                    listaNombres.Add(nombreCampo);
            }
            if (hayError)
                MessageBox.Show(mesnsajeError, "** Hay errores en los campos **", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return hayError;
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que desea borrar los datos?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                richtxt.Clear();
            dataGridView1.Rows.Clear();

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (dataGrid.CurrentCell.RowIndex >= 1 && dataGrid.CurrentCell.RowIndex < dataGrid.RowCount - 1)
            {
                int filaSeleccionada = dataGrid.CurrentCell.RowIndex;
                dataGrid.Rows.Insert(filaSeleccionada - 1, dataGrid.Rows[filaSeleccionada].Cells[0].Value, dataGrid.Rows[filaSeleccionada].Cells[1].Value, dataGrid.Rows[filaSeleccionada].Cells[2].Value, dataGrid.Rows[filaSeleccionada].Cells[3].Value);
                dataGrid.Rows.RemoveAt(filaSeleccionada + 1);
                dataGrid.Refresh();
                dataGrid.CurrentCell = dataGrid.Rows[filaSeleccionada - 1].Cells[0];
                dataGrid.Rows[filaSeleccionada - 1].Selected = true;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (dataGrid.CurrentCell.RowIndex < dataGrid.RowCount - 2)
            {
                int filaSeleccionada = dataGrid.CurrentCell.RowIndex;
                dataGrid.Rows.Insert(filaSeleccionada+2, dataGrid.Rows[filaSeleccionada].Cells[0].Value, dataGrid.Rows[filaSeleccionada].Cells[1].Value, dataGrid.Rows[filaSeleccionada].Cells[2].Value, dataGrid.Rows[filaSeleccionada].Cells[3].Value);
                dataGrid.Rows.RemoveAt(filaSeleccionada);
                dataGrid.Refresh();
                dataGrid.CurrentCell = dataGrid.Rows[filaSeleccionada + 1].Cells[0];
                dataGrid.Rows[filaSeleccionada + 1].Selected = true;
            }
        }
    }
}
