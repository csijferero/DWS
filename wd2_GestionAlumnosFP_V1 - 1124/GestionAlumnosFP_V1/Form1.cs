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
        // Construimos los adaptadores y tablas que necesitamos
        GruposTableAdapter gruposAdapter = new GruposTableAdapter();
        DataSet1.GruposDataTable gruposTabla = new DataSet1.GruposDataTable();

        AlumnosTableAdapter alumnosAdapter = new AlumnosTableAdapter();
        DataSet1.AlumnosDataTable alumnosTabla = new DataSet1.AlumnosDataTable();

        bool comboCargado = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            List<Grupo> listaGrupos = new List<Grupo>();
            // cargamos la tabla de Grupos
            // gruposAdapt.Fill(gruposTabla);
            gruposTabla = gruposAdapter.GetData();

            // Cargo la lista con los objetos grupo obtenido a partir de los registros de la tabla
            listaGrupos.Add(new Grupo(0, "Todos", "Todos los grupos")); // <-- Cargo este grupo ficticio para que salga en primer lugar
            foreach (DataSet1.GruposRow regGrupo in gruposTabla)
                listaGrupos.Add(new Grupo(regGrupo));

            // Pongo la lista como origen de datos del combo
            cbGrupos.DataSource = listaGrupos;
            cbGrupos.DisplayMember = "Nombre"; // <-- Indicamos qué propiedad se va a mostrar
            cbGrupos.ValueMember = "IdGrupo";// <-- Indicamos qué propiedad se va a guardar en Value
            comboCargado = true;
            
            // Cargamos la tabla de alumnos
            CargaAlumnosGrupo();

            // Asociamos esa tabla al DataGridView
            dgv.DataSource = alumnosTabla;

            dgv.Columns[0].Visible = false;
            dgv.Columns["idGrupo"].Visible = false;
        }

        private void cbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCargado)
                CargaAlumnosGrupo();
        }

        void CargaAlumnosGrupo()
        {
            {
                int idGrupo = Convert.ToInt32(cbGrupos.SelectedValue);
                if (idGrupo == 0) //<-- Significa que hemos elegido "Todos los Grupos"
                    alumnosTabla = alumnosAdapter.GetData();
                else
                {
                    // Hemos elegido un grupo de los existentes
                    // Previamente añado al adaptador de alumnos el Select según grupo
                    // ahora la uso
                    alumnosTabla = alumnosAdapter.GetDataByIdGrupo(idGrupo);
                }
                dgv.DataSource = alumnosTabla;

                lbCabecera.Text = String.Format("Alumnos de {0} ({1} alumnos)", cbGrupos.Text, dgv.RowCount);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // obtengo el id del alumno que quiero eliminar
            int idAlumno = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);

            // Obtengo el registro correspondiente a dicho alumno
            DataSet1.AlumnosRow regAlumno = alumnosTabla.FindByidAlumno(idAlumno);
            
            // elimino el registro
            regAlumno.Delete();

            // actualizo la BD
            alumnosAdapter.Update(regAlumno);
        }
    }
}
