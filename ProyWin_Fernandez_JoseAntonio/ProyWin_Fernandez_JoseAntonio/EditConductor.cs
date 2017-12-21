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
        bool nuevo;
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

        public bool Nuevo
        {
            get
            {
                return nuevo;
            }

            set
            {
                nuevo = value;
            }
        }

        public EditConductor()
        {
            InitializeComponent();
        }

        
    }
}
