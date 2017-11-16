using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridView_a_Lista
{
    public partial class Form2 : Form
    {
        int seleccionado = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            seleccionado = ((Form1)(this.Owner)).Fila;
            txtNom.Text = ((Form1)(this.Owner)).ListaEquipos[seleccionado].Nombre;
            numPunt.Value = ((Form1)(this.Owner)).ListaEquipos[seleccionado].Puntos;
            numGan.Value = ((Form1)(this.Owner)).ListaEquipos[seleccionado].Pg;
            numEmp.Value = ((Form1)(this.Owner)).ListaEquipos[seleccionado].Pe;
            numPerd.Value = ((Form1)(this.Owner)).ListaEquipos[seleccionado].Pp;
            numFav.Value = ((Form1)(this.Owner)).ListaEquipos[seleccionado].Gf;
            numCont.Value = ((Form1)(this.Owner)).ListaEquipos[seleccionado].Gc;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro qué desea realizar las modificaciones?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ((Form1)(this.Owner)).ListaEquipos[seleccionado].Nombre = txtNom.Text;
                ((Form1)(this.Owner)).ListaEquipos[seleccionado].Puntos = Convert.ToByte(numPunt.Value);
                ((Form1)(this.Owner)).ListaEquipos[seleccionado].Pg = Convert.ToByte(numGan.Value);
                ((Form1)(this.Owner)).ListaEquipos[seleccionado].Pe = Convert.ToByte(numEmp.Value);
                ((Form1)(this.Owner)).ListaEquipos[seleccionado].Pp = Convert.ToByte(numPerd.Value);
                ((Form1)(this.Owner)).ListaEquipos[seleccionado].Gf = Convert.ToByte(numFav.Value);
                ((Form1)(this.Owner)).ListaEquipos[seleccionado].Gc = Convert.ToByte(numCont.Value);
                ((Form1)(this.Owner)).refrescar();
                this.Close();
            }
        }
    }
}
