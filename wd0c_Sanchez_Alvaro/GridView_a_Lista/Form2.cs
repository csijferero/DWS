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
        private Equipo equipo;
        private List<Equipo> lisEquipo;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Equipo equipo)
        {
            this.equipo = equipo;
            InitializeComponent();
        }

        public Equipo Equipo
        {
            get
            {
                return equipo;
            }

            set
            {
                equipo = value;
            }
        }

        public List<Equipo> LisEquipo
        {
            get
            {
                return lisEquipo;
            }

            set
            {
                lisEquipo = value;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtNombre.Text = equipo.Nombre;
            txtPuntos.Text = equipo.Puntos.ToString();
            txtGanados.Text = equipo.Pg.ToString();
            txtEmpatados.Text = equipo.Pe.ToString();
            txtPerdidos.Text = equipo.Pp.ToString();
            txtFavor.Text = equipo.Gf.ToString();
            txtEncontra.Text = equipo.Gc.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            errorProvider1.Clear();
            if (HayError())
                return;
            int pos = 0;
            for (int i = 0; i < lisEquipo.Count; i++)
            {
                if (lisEquipo[i].Nombre == equipo.Nombre)
                {
                    pos = i;
                    break;
                }                     
            }

            ModificarCampos(pos);
            this.DialogResult = DialogResult.OK;
        }

        private void ModificarCampos(int pos)
        {
            lisEquipo[pos].Nombre = txtNombre.Text;
            lisEquipo[pos].Puntos = Convert.ToByte(txtPuntos.Text);
            lisEquipo[pos].Pg = Convert.ToByte(txtGanados.Text);
            lisEquipo[pos].Pe = Convert.ToByte(txtEmpatados.Text);
            lisEquipo[pos].Pp = Convert.ToByte(txtPerdidos.Text);
            lisEquipo[pos].Gf = Convert.ToByte(txtFavor.Text);
            lisEquipo[pos].Gc = Convert.ToByte(txtEncontra.Text);
        }

        private bool HayError()
        {
            string frase = null;
            bool hayError = false;
            byte aux;
            if (txtNombre.Text.Length < 1)
            {
                hayError = true;
                frase += "El nombre no puede estar vacio\n";
                errorProvider1.SetError(txtNombre, "El nombre no puede estar vacio");
            }
            if (!byte.TryParse(txtPuntos.Text, out aux))
            {
                hayError = true;
                frase += "Los puntos no son del formato correcto\n";
                errorProvider1.SetError(txtPuntos, "Los puntos no son del formato correcto");
            }
            if (!byte.TryParse(txtGanados.Text, out aux))
            {
                hayError = true;
                frase += "Los partidos ganados no son del formato correcto\n";
                errorProvider1.SetError(txtGanados, "Los partidos ganados no son del formato correcto");
            }
            if (!byte.TryParse(txtEmpatados.Text, out aux))
            {
                hayError = true;
                frase += "Los partidos empatados no son del formato correcto\n";
                errorProvider1.SetError(txtEmpatados, "Los partidos empatados no son del formato correcto");
            }
            if (!byte.TryParse(txtPerdidos.Text, out aux))
            {
                hayError = true;
                frase += "Los partidos perdidos no son del formato correcto\n";
                errorProvider1.SetError(txtPerdidos, "Los partidos perdidos no son del formato correcto");
            }
            if (!byte.TryParse(txtFavor.Text, out aux))
            {
                hayError = true;
                frase += "Los goles a favor no son del formato correcto\n";
                errorProvider1.SetError(txtFavor, "Los goles a favor no son del formato correcto");
            }
            if (!byte.TryParse(txtEncontra.Text, out aux))
            {
                hayError = true;
                frase += "Los goles en contra no son del formato correcto\n";
                errorProvider1.SetError(txtEncontra, "Los goles en contra no son del formato correcto");
            }
            if (hayError)
                MessageBox.Show(frase, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return hayError;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < lisEquipo.Count; i++)
            {
                if (lisEquipo[i].Nombre == equipo.Nombre)
                {
                    lisEquipo.RemoveAt(i);
                    break;
                }
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
