using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LNegocioyADatos;

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

            // Muestro la columna de borrar al final del dgv.
            dgv.Columns[1].DisplayIndex = dgv.Columns.Count - 1;

        }

        private void CargaCombos()
        {
            List<Grupo> listaGrupos = LNyAD.ListaGrupos();

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
    }
}
