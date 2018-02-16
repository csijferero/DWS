using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNegocioyADatos
{
    public class Clientes
    {
        int idCliente;
        string nombreCliente;
        string apellidosCliente;
        string direccionCliente;
        string emailCliente;
        string dniCliente;

        public Clientes(int idCliente, string nombreCliente, string apellidosCliente, string direccionCliente, string emailCliente, string dniCliente)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.direccionCliente = direccionCliente;
            this.emailCliente = emailCliente;
            this.dniCliente = dniCliente;
        }

        public Clientes()
        {
            this.idCliente = -1;
            this.nombreCliente = String.Empty;
            this.apellidosCliente = String.Empty;
            this.direccionCliente = String.Empty;
            this.emailCliente = String.Empty;
            this.dniCliente = String.Empty;
        }

        public Clientes(taxiDataSet.clientesRow regClientes)
        {
            this.idCliente = regClientes.idCliente;
            this.nombreCliente = regClientes.nombreCliente;
            this.apellidosCliente = regClientes.apellidosCliente;
            this.direccionCliente = regClientes.direccionCliente;
            this.emailCliente = regClientes.emailCliente;
            this.dniCliente = regClientes.dniCliente;
        }

        public int IdCliente
        {
            get
            {
                return idCliente;
            }

            set
            {
                idCliente = value;
            }
        }

        public string NombreCliente
        {
            get
            {
                return nombreCliente;
            }

            set
            {
                nombreCliente = value;
            }
        }

        public string ApellidosCliente
        {
            get
            {
                return apellidosCliente;
            }

            set
            {
                apellidosCliente = value;
            }
        }

        public string DireccionCliente
        {
            get
            {
                return direccionCliente;
            }

            set
            {
                direccionCliente = value;
            }
        }

        public string EmailCliente
        {
            get
            {
                return emailCliente;
            }

            set
            {
                emailCliente = value;
            }
        }

        public string DniCliente
        {
            get
            {
                return dniCliente;
            }

            set
            {
                dniCliente = value;
            }
        }
    }
}
