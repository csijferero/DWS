using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaBBDD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.dataSet1.Alumnos);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.dataSet1.Alumnos);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.dataSet1.Alumnos);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Grupos' Puede moverla o quitarla según sea necesario.
            this.gruposTableAdapter.Fill(this.dataSet1.Grupos);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.dataSet1.Alumnos);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Grupos' Puede moverla o quitarla según sea necesario.
            this.gruposTableAdapter.Fill(this.dataSet1.Grupos);

        }
    }
}
