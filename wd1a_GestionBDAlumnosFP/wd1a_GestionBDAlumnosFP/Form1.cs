using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wd1a_GestionBDAlumnosFP.DataSet1TableAdapters;

namespace wd1a_GestionBDAlumnosFP
{
    public partial class Form1 : Form
    {

        GruposTableAdapter gruposAdapt = new GruposTableAdapter();
        DataSet1.GruposDataTable gruposTabla = new DataSet1.GruposDataTable();

        

        public Form1()
        {
            InitializeComponent();


            //cargamos la tabla de Grupos
            //gruposAdapt.Fill(gruposTabla);
            gruposTabla = gruposAdapt.GetData();

            Grupo grupos = new Grupo(gruposTabla);


            cbGrupos.DataSource = gruposTabla;


        }
    }
}
