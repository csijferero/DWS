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
    public partial class EditCliente : Form
    {
        Clientes cli;
        public Clientes Cli
        {
            get
            {
                return cli;
            }

            set
            {
                cli = value;
            }
        }
        public EditCliente()
        {
            InitializeComponent();
        }

        
    }
}
