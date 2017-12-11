using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LNegocioyAdatos;

namespace InterfazUsuario
{
    public partial class IUAlumnos : Form
    {
        // Construyo el formulario detalle que voy a usar en toda la aplicación
        IUDetalleAlumno fDetalle = new IUDetalleAlumno();
        bool comboCargado = false;
        public IUAlumnos()
        {
            InitializeComponent();
        }

        private void IUAlumnos_Load(object sender, EventArgs e)
        {
            // Cargamos los combos
            CargaCombos();
            // Cargamos la tabla de alumnos
            CargaAlumnosGrupo();

            //... pero la muestro al final del dgv.
            dgv.Columns[1].DisplayIndex = dgv.Columns.Count - 1;
        }
        private void CargaCombos()
        {
            List<Grupo> listaGrupos = LNyAD.ListaGrupo();

            List<Grupo> listaTodosMasGrupos;
            // construyo la segunda lista con los grupos de la primera
            listaTodosMasGrupos = new List<Grupo>(listaGrupos);
            // Inserto en primer lugar el "grupo Todos"
            listaTodosMasGrupos.Insert(0, new Grupo(0, "Todos", "Todos los grupos")); // <-- Cargo este grupo ficticio para que salga en primer lugar


            // Pongo la lista "listaTodosMasGrupos" como origen de datos del combo del principal
            cbGrupos.DataSource = listaTodosMasGrupos;
            cbGrupos.DisplayMember = "Nombre"; // <-- Indicamos qué propiedad se va a mostrar
            cbGrupos.ValueMember = "IdGrupo";// <-- Indicamos qué propiedad se va a guardar en Value
            comboCargado = true;
            // Y la lista básica del combo del formDetalle
            fDetalle.cbGruposDetalle.DataSource = listaGrupos;
            fDetalle.cbGruposDetalle.DisplayMember = "Nombre"; // <-- Indicamos qué propiedad se va a mostrar
            fDetalle.cbGruposDetalle.ValueMember = "IdGrupo";// <-- Indicamos qué propiedad se va a guardar en Value

        }

        void CargaAlumnosGrupo()
        {
            int idGrupo = Convert.ToInt32(cbGrupos.SelectedValue);

            // Asociamos esa tabla al DataGridView
            dgv.DataSource = LNyAD.TablaAlumnos(idGrupo);

            // ocultábamos las columnas de id's
            dgv.Columns["idAlumno"].Visible = false;
            dgv.Columns["idGrupo"].Visible = false;
            // si es un grupo concreto oculto la columna grupo porque ya aparece en la cabecera
            dgv.Columns["Grupo"].Visible = (idGrupo == 0);

            lbCabecera.Text = String.Format("Alumnos de {0} ({1} alumnos)", cbGrupos.Text, dgv.RowCount);
        }

        private void cbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCargado)
                CargaAlumnosGrupo();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int colum = e.ColumnIndex;
            int fila = e.RowIndex;

            if (colum == 0) // <-- he pulsado el botón Editar
                EditarRegistro(fila);
            else if (dgv.Columns[colum].HeaderText == "Del")// <-- he pulsado el botón Borrar
                BorarRegistro(fila);
            else
                return; // <-- No he pulsado ninguno de los botones que me iteresan
        }

        private void BorarRegistro(int fila)
        {
            if (DialogResult.No == MessageBox.Show("¿está seguro de eliminar a:\n" + dgv.Rows[fila].Cells["apellidosNombre"].Value.ToString() + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                return;
            // obtengo el id del alumno que quiero eliminar
            int idAlumno = Convert.ToInt32(dgv.Rows[fila].Cells[2].Value);

            LNyAD.BorrarRegistroAlumno(idAlumno);
            lbCabecera.Text = string.Format("Alumnos de {0} ({1} alumnos)", cbGrupos.Text, dgv.RowCount);
        }

        private void EditarRegistro(int fila)
        {
            if (fila == -1) // "Pa porsi" has pulsado en la cabecera de los botones
                return;
            int idAlumno = Convert.ToInt32(dgv.Rows[fila].Cells[2].Value);
            Alumno alum = LNyAD.ObtenerAlumnoPorId(idAlumno);
            // Asigno el alumno a la propiedad correspondiente del formulario...
            fDetalle.Alum = alum;

            //... y muestro el formulario para poder modificar
            if (fDetalle.ShowDialog() == DialogResult.OK)
                LNyAD.ActualizarAlumno(alum); // si he salido con OK, Actualizo
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            // Construimos un alumno nuevo
            Alumno alum = new Alumno();

            // Asigno el alumno vacío a la propiedad correspondiente del formulario...
            fDetalle.Alum = alum;
            //... y muestro el formulario para poder modificar
            if (fDetalle.ShowDialog() == DialogResult.OK)
            {
                // si he salido con OK, inserto
                LNyAD.InsertarAlumno(alum);
                // Para que aparezca el idAlumno real de la BD volvemos a cargar la tabla
                CargaAlumnosGrupo();
            }
        }
    }
}
