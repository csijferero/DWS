using LNegocioyAdatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazUsuario
{
    public partial class IUDetalleAlumno : Form
    {
        Alumno alum;
        bool esNuevo;
        List<Grupo> listaGrupos;
        public IUDetalleAlumno(List<Grupo> listaGrupos)
        {
            InitializeComponent();
            this.listaGrupos = listaGrupos;
            this.alum = new Alumno();
            esNuevo = true;
        }

        public IUDetalleAlumno(List<Grupo> listaGrupos, Alumno alum)
        {
            InitializeComponent();
            this.listaGrupos = listaGrupos;
            this.alum = alum;
            esNuevo = false;
        }

        //public Alumno Alum
        //{
        //    get
        //    {
        //        return alum;
        //    }

        //    set
        //    {
        //        alum = value;
        //    }
        //}

        private void IUDetalleAlumno_Load(object sender, EventArgs e)
        {
            // Cargo la lista básica del combo de grupos
            cbGruposDetalle.DataSource = listaGrupos;
            cbGruposDetalle.DisplayMember = "Nombre"; // <-- Indicamos qué propiedad se va a mostrar
            cbGruposDetalle.ValueMember = "IdGrupo";// <-- Indicamos qué propiedad se va a guardar en Value

            // si indice es negativo oculto el textBox, en caso contrario lo muestro
            txbIndice.Visible = (alum.IdAlumno > 0);

            txbIndice.Text = alum.IdAlumno.ToString();
            txbApellNom.Text = alum.ApellidosNombre;
            txbDni.Text = alum.Dni;
            txbMovil.Text = alum.Movil;
            txbTelefono.Text = alum.Telefono;
            txbMail.Text = alum.Email;
            cbGruposDetalle.SelectedValue = alum.IdGrupo;
            if (alum.IdGrupo < 0)
                cbGruposDetalle.Text = "Seleccione un grupo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (HayErrorEnFormulario())
                return;

            // actualizo el alumno
            alum.ApellidosNombre = txbApellNom.Text;
            alum.Dni = txbDni.Text;
            alum.Movil = txbMovil.Text;
            alum.Telefono = txbTelefono.Text;
            alum.Email = txbMail.Text;
            alum.IdGrupo = (int)cbGruposDetalle.SelectedValue;

            if(esNuevo)
                LNyAD.InsertarAlumno(alum);
            else
                LNyAD.ActualizarAlumno(alum);

            // Me salgo respondiendo OK
            this.DialogResult = DialogResult.OK;
        }

        private bool HayErrorEnFormulario()
        {
            return false;
        }
    }
}
