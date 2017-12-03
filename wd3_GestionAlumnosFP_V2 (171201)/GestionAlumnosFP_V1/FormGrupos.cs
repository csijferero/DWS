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
    public partial class FormGrupos : Form
    {
        // Construimos los adaptadores y tablas que necesitamos
        GruposTableAdapter gruposAdapter2 = new GruposTableAdapter();
        DataSet1.GruposDataTable gruposTabla2 = new DataSet1.GruposDataTable();

        AlumnosTableAdapter alumnosAdapter2 = new AlumnosTableAdapter();
        DataSet1.AlumnosDataTable alumnosTabla2 = new DataSet1.AlumnosDataTable();
        // Construyo el formulario detalle que voy a usar en toda la aplicación
        FormDetalleGrupos fDetalleGrupo = new FormDetalleGrupos();
        // FormAlumno formulario = new FormAlumno();

        internal bool cambio;

        public FormGrupos()
        {
            InitializeComponent();
        }

        private void FormGrupos_Load(object sender, EventArgs e)
        {
            // Cargamos la tabla de alumnos
            CargaGrupos();

            // Vamos a añadir el botón de borrar
            DataGridViewButtonColumn btnBorrar = new DataGridViewButtonColumn();
            if (dgv2.Columns[1].HeaderText != "Del")
            {
                btnBorrar.Width = 40;
                btnBorrar.HeaderText = "Del";
                btnBorrar.ToolTipText = "Eliminar Registro";
                btnBorrar.Text = "X";
                btnBorrar.UseColumnTextForButtonValue = true;
                //La coloco detrás de el botón Edit...
                dgv2.Columns.Insert(1, btnBorrar);
                //... pero la muestro al final del dgv.
                dgv2.Columns[1].DisplayIndex = dgv2.Columns.Count - 1;
            }
        }

        void CargaGrupos()
        {
            gruposTabla2 = gruposAdapter2.GetData();
            // Asociamos esa tabla al DataGridView
            dgv2.DataSource = gruposTabla2;

        }

        private void btnAnadirRegistro_Click(object sender, EventArgs e)
        {
            // Construimos un grupo nuevo
            Grupo grupo = new Grupo();

            // Construimos un registro nuevo
            DataSet1.GruposRow regGrupo = gruposTabla2.NewGruposRow();

            fDetalleGrupo.Grupo = grupo;
            if (fDetalleGrupo.ShowDialog() == DialogResult.OK)
            {
                cambio = true;
                // actualizo el registro
                regGrupo.nombre = grupo.Nombre;
                regGrupo.alias = grupo.Alias;
                regGrupo.idGrupo = grupo.Idgrupo;
                regGrupo.idTutor = grupo.Idtutor;
                regGrupo.idDpto = grupo.Iddpto;

                gruposTabla2.AddGruposRow(regGrupo);
                // actualizo la bd
                gruposAdapter2.Update(regGrupo);
                // Para que aparezca el idgrupo real de la BD volvemos a cargar la tabla
                CargaGrupos();
            }
        }

        private void dgv2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int colum = e.ColumnIndex;
            int fila = e.RowIndex;

            if (colum == 0) // <-- he pulsado el botón Editar
                EditarRegistro(fila);
            else if (dgv2.Columns[colum].HeaderText == "Del")// <-- he pulsado el botón Borrar
                BorarRegistro(fila);
            else
                return; // <-- No he pulsado ninguno de los botones que me iteresan

        }

        private void BorarRegistro(int fila)
        {
            if (fila >= 0)
            {
                if (DialogResult.No == MessageBox.Show("¿está seguro de eliminar a:\n" + dgv2.Rows[fila].Cells["nombre"].Value.ToString() + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    return;
                // obtengo el id del alumno que quiero eliminar
                int idGrupo = Convert.ToInt32(dgv2.Rows[fila].Cells[2].Value);

                // Obtengo el registro correspondiente a dicho alumno
                DataSet1.GruposRow regGrupo = gruposTabla2.FindByidGrupo(idGrupo);

                alumnosTabla2 = alumnosAdapter2.GetDataConIdGrupo();
                int[] tabla = new int[alumnosTabla2.Count];


                for (int i = 0; i < alumnosTabla2.Count; i++)
                {
                    tabla[i] = alumnosTabla2[i].idGrupo;
                }

                if (!tabla.Contains(idGrupo))
                {

                    cambio = true;
                    // elimino el registro
                    regGrupo.Delete();

                    // actualizo la BD
                    gruposAdapter2.Update(regGrupo);

                    //** Otra forma: borramos el registro en la BD y recargamos la tabla
                    //alumnosAdapter.DeleteByIdAlumno(idAlumno);
                    //// cargar de nuevo la tabla del dgv
                    //CargaAlumnosGrupo();
                }
                else
                {
                    MessageBox.Show("Hay usuarios asignados a este grupo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EditarRegistro(int fila)
        {
            if (fila >= 0)
            {
                // obtengo el id del alumno que quiero eliminar
                int idGrupo = Convert.ToInt32(dgv2.Rows[fila].Cells[2].Value);

                // Obtengo el registro correspondiente a dicho alumno
                DataSet1.GruposRow regGrupo = gruposTabla2.FindByidGrupo(idGrupo);

                // Construimos el alumnos a editar
                Grupo grupo = new Grupo(regGrupo);

                fDetalleGrupo.Grupo = grupo;
                if (fDetalleGrupo.ShowDialog() == DialogResult.OK)
                {
                    cambio = true;
                    // actualizo el registro
                    regGrupo.nombre = grupo.Nombre;
                    regGrupo.alias = grupo.Alias;
                    regGrupo.idGrupo = grupo.Idgrupo;
                    regGrupo.idTutor = grupo.Idtutor;

                    // actualizo la bd
                    gruposAdapter2.Update(regGrupo);
                    // Construyo el formulario form1 que voy a usar en toda la aplicación
                }
            }
        }
    }
}
