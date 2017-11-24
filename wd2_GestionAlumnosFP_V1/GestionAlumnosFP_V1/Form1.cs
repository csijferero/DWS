using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionAlumnosFP_V1.DataSet1TableAdapters;

namespace GestionAlumnosFP_V1
{
    public partial class Form1 : Form
    {
        GruposTableAdapter gruposAdapter = new GruposTableAdapter();
        DataSet1.GruposDataTable gruposTabla = new DataSet1.GruposDataTable();

        public Form1()
        {
            InitializeComponent();
            // cargamos la tabla de Grupos
            // gruposAdapt.Fill(gruposTabla);
            gruposTabla = gruposAdapter.GetData();

            cbGrupos.DataSource = gruposTabla.Rows;

        }
    }
}
