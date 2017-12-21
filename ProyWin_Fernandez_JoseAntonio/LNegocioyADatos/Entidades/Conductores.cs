using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNegocioyADatos
{
    public class Conductores
    {
        int idConductor;
        string nombreConductor;
        string apellidosConductor;
        string direccionConductor;
        string emailConductor;
        string dniConductor;
        int licenciaConductor;
        string matriculaConductor;

        public Conductores(int idConductor, string nombreConductor, string apellidosConductor, string direccionConductor, string emailConductor, string dniConductor, int licenciaConductor, string matriculaConductor)
        {
            this.idConductor = idConductor;
            this.nombreConductor = nombreConductor;
            this.apellidosConductor = apellidosConductor;
            this.direccionConductor = direccionConductor;
            this.emailConductor = emailConductor;
            this.dniConductor = dniConductor;
            this.licenciaConductor = licenciaConductor;
            this.matriculaConductor = matriculaConductor;
        }

        public Conductores()
        {
            this.idConductor = -1;
            this.nombreConductor = String.Empty;
            this.apellidosConductor = String.Empty;
            this.direccionConductor = String.Empty;
            this.emailConductor = String.Empty;
            this.dniConductor = String.Empty;
            this.licenciaConductor = -1;
            this.matriculaConductor = String.Empty;
        }
        public Conductores(taxiDataSet.conductoresRow regConductores)
        {
            this.idConductor = regConductores.idConductor;
            this.nombreConductor = regConductores.nombreConductor;
            this.apellidosConductor = regConductores.apellidosConductor;
            this.direccionConductor = regConductores.direccionConductor;
            this.emailConductor = regConductores.emailConductor;
            this.dniConductor = regConductores.dniConductor;
            this.licenciaConductor = regConductores.licenciaConductor;
            this.matriculaConductor = regConductores.matriculaConductor;
        }

        public int IdConductor
        {
            get
            {
                return idConductor;
            }

            set
            {
                idConductor = value;
            }
        }

        public string NombreConductor
        {
            get
            {
                return nombreConductor;
            }

            set
            {
                nombreConductor = value;
            }
        }

        public string ApellidosConductor
        {
            get
            {
                return apellidosConductor;
            }

            set
            {
                apellidosConductor = value;
            }
        }

        public string DireccionConductor
        {
            get
            {
                return direccionConductor;
            }

            set
            {
                direccionConductor = value;
            }
        }

        public string EmailConductor
        {
            get
            {
                return emailConductor;
            }

            set
            {
                emailConductor = value;
            }
        }

        public string DniConductor
        {
            get
            {
                return dniConductor;
            }

            set
            {
                dniConductor = value;
            }
        }

        public int LicenciaConductor
        {
            get
            {
                return licenciaConductor;
            }

            set
            {
                licenciaConductor = value;
            }
        }

        public string MatriculaConductor
        {
            get
            {
                return matriculaConductor;
            }

            set
            {
                matriculaConductor = value;
            }
        }
    }
}
