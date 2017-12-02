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
    public partial class FormDetalleGrupos : Form
    {
        // Construimos los adaptadores y tablas que necesitamos
        GruposTableAdapter gruposAdapter2 = new GruposTableAdapter();
        DataSet1.GruposDataTable gruposTabla2 = new DataSet1.GruposDataTable();

        Grupo grupo;
        public FormDetalleGrupos()
        {
            InitializeComponent();
        }

        public Grupo Grupo
        {
            get
            {
                return grupo;
            }

            set
            {
                grupo = value;
            }
        }

        private void FormDetalleGrupos_Load(object sender, EventArgs e)
        {
            // si indice es negativo oculto el textBox, en caso contrario lo muestro
            txbIndiceGrupo.Visible = (grupo.Idgrupo >= 0);

            txbIndiceGrupo.Text = grupo.Idgrupo.ToString();
            txbNombre.Text = grupo.Nombre;
            txbAlias.Text = grupo.Alias;
            txbTutor.Text = grupo.Idtutor;
            txbDpto.Text = grupo.Iddpto;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            errorProvider1.Clear();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (HayErrorEnFormulario())
                return;


            // actualizo el alumno
            grupo.Nombre = txbNombre.Text;
            grupo.Alias = txbAlias.Text.ToUpper();
            grupo.Idtutor = txbTutor.Text.ToUpper();
            grupo.Iddpto = txbDpto.Text.ToUpper();
            grupo.Idgrupo = Convert.ToInt32(txbIndiceGrupo.Text);

            // Me salgo respondiendo OK
            this.DialogResult = DialogResult.OK;
        }

        private bool HayErrorEnFormulario()
        {
            string text = "";
            bool error = false;

            gruposTabla2 = gruposAdapter2.GetDataAlias();
            string[] tabla = new string[gruposTabla2.Count];
            for (int i = 0; i < gruposTabla2.Count; i++)
            {
                if(gruposTabla2[i].alias != grupo.Alias)
                tabla[i] = gruposTabla2[i].alias;
            }


            if (txbAlias.Text == String.Empty)
            {
                text += "Campo Alias vacio";
                error = true;
                errorProvider1.SetError(txbAlias, "Vacio");
            }
            if (txbIndiceGrupo.Text == String.Empty)
            {
                text += "Campo Indice vacio";
                error = true;
                errorProvider1.SetError(txbIndiceGrupo, "Vacio");
            }
            if (txbDpto.Text == String.Empty)
            {
                text += "Campo Departamento vacio";
                error = true;
                errorProvider1.SetError(txbDpto, "Vacio");
            }
            if (txbNombre.Text == String.Empty)
            {
                text += "Campo Nombre vacio";
                error = true;
                errorProvider1.SetError(txbNombre, "Vacio");
            }
            if (tabla.Contains(txbAlias.Text))
            {
                text += "Alias repetido";
                error = true;
                errorProvider1.SetError(txbAlias, "Vacio");
            }
            if (error)
                MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return error;
        }
    }
}
