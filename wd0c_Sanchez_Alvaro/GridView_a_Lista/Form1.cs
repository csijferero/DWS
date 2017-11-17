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

        private void btnCargarFichero_Click(object sender, EventArgs e)
        {
            Equipo equipo;

            //Construir un StreamReader
            Stream myStream = null;
            StreamReader sr = null;

            //Abrimos el OpenFileDialog para elegir el fichero que nos interese
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog.OpenFile()) != null)
                {
                    try
                    {
                        //...Hacemos que el StreamReader se asocie al fichero seleccionado
                        //  Abrimos el fichero
                        sr = new StreamReader(myStream, Encoding.Default);

                        //  Lo recorremos capturando cada linea del fichero
                        clbAnadidos.Items.Clear(); // <-- Limpiamos la lista chequeable para recargarla
                        string linea;

                        while (!sr.EndOfStream)
                        {
                            linea = sr.ReadLine();


                            if (linea.Length != 0)
                            {
                                // Construimos el equipo a partir de la linea
                                equipo = new Equipo(linea);
                                // Lo añadimos al chListBox: Hemos sobreescrito el .ToString() para esto
                                clbAnadidos.Items.Add(equipo);
                                // Lo añadimos a la lista de equipos
                                listaEquipos.Add(equipo);
                            }
                        }
                        lbAnadidos.Text = "Equipo        Pts Pg Pe Pp gf gc";
                        sr.Close();
                        dgv.DataSource = listaEquipos;

                        // centramos horizontalmente las columnas de datos numéricos
                        for (int i = 2; i < dgv.Columns.Count; i++)
                        {
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        }
                        //Activamos los radiobuttons y disparamos el chequedchangued
                        rbPuntos.Checked = true;
                        gbOrdenacion.Enabled = true;
                    }
                    catch
                    {
                        sr.Close();
                        MessageBox.Show("** El fichero elegido contiene errores de formato **", "Fallo de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
             Hacer que al pulsar en el botón editar de un registro se muestre 
             un formulario en el que actualizar los datos. 
             Al pulsar Aceptar se actualiza la lista y se refresca el dgv.
             */
            int fila = e.RowIndex;      //<-- ¿En qué fila he picado?
            int colum = e.ColumnIndex;  //<-- ¿En qué columna he picado?
            if (fila < 0 && colum == 0)
                return;
            Form2 form2 = new Form2(new Equipo(dgv.Rows[fila].Cells[1].Value.ToString(),
                                               Convert.ToByte(dgv.Rows[fila].Cells[2].Value.ToString()),
                                               Convert.ToByte(dgv.Rows[fila].Cells[3].Value.ToString()),
                                               Convert.ToByte(dgv.Rows[fila].Cells[4].Value.ToString()),
                                               Convert.ToByte(dgv.Rows[fila].Cells[5].Value.ToString()),
                                               Convert.ToByte(dgv.Rows[fila].Cells[6].Value.ToString()),
                                               Convert.ToByte(dgv.Rows[fila].Cells[7].Value.ToString())
                ));
            form2.LisEquipo = listaEquipos;
            DialogResult dialogo = form2.ShowDialog();
            if (dialogo == DialogResult.OK)
            {
                clbAnadidos.Items.Clear(); 
                // Recargamos la lista checkeable  
                foreach (Equipo eq in listaEquipos)                
                    clbAnadidos.Items.Add(eq);  
                // Y refrescamos el dgv para que se vean los cambios  
                dgv.Refresh();

                MessageBox.Show("El equipo ha sido actualizado", "Actualización correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form2.Close();
                form2.Dispose();
            }
               
            
        }

        private void btnOrdenarListaEquipos_Click(object sender, EventArgs e)
        {
            listaEquipos.Reverse();
            dgv.Refresh();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            clbAnadidos.Items.Clear();

            foreach (Equipo eq in listaEquipos)
            {
                clbAnadidos.Items.Add(eq);
            }
        }

        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {
            listaEquipos.Sort((p, q) => string.Compare(p.Nombre, q.Nombre));
            dgv.Refresh();
        }

        private void rbPuntos_CheckedChanged(object sender, EventArgs e)
        {
            listaEquipos.Sort((p, q) => string.Compare(q.Puntos.ToString("00"), p.Puntos.ToString("00")));
            //listaEquipos.Reverse();
            dgv.Refresh();
        }


    }
}
