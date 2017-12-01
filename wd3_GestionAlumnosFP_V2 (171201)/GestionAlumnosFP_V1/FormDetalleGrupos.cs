using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAlumnosFP_V1
{
    public partial class FormDetalleGrupos : Form
    {
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
    }
}
