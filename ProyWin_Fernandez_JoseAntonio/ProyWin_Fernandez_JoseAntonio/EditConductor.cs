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
    public partial class EditConductor : Form
    {
        Conductores cond;
        public Conductores Cond
        {
            get
            {
                return cond;
            }

            set
            {
                cond = value;
            }
        }
        public EditConductor()
        {
            InitializeComponent();
        }

        
    }
}
