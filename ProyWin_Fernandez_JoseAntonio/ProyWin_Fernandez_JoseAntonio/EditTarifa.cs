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
    public partial class EditTarifa : Form
    {
        Tarifas tar;
        public Tarifas Tar
        {
            get
            {
                return tar;
            }

            set
            {
                tar = value;
            }
        }

        public EditTarifa()
        {
            InitializeComponent();
        }
    }
}
