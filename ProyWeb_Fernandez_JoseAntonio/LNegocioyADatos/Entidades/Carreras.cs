using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNegocioyADatos
{
    public class Carreras
    {
        int idCarrera;
        string origen;
        string destino;
        DateTime fecha;
        int metros;
        int duracion;
        int idTarifa;
        int idConductor;
        int idCliente;

        public Carreras(int idCarrera, string origen, string destino, DateTime fecha, int metros, int duracion, int idTarifa, int idConductor, int idCliente)
        {
            this.idCarrera = idCarrera;
            this.origen = origen;
            this.destino = destino;
            this.fecha = fecha;
            this.metros = metros;
            this.duracion = duracion;
            this.idTarifa = idTarifa;
            this.idConductor = idConductor;
            this.idCliente = idCliente;
        }

        public Carreras()
        {
            this.idCarrera = -1;
            this.origen = String.Empty;
            this.destino = String.Empty;
            this.fecha = DateTime.Today;
            this.metros = -1;
            this.duracion = -1;
            this.idTarifa = -1;
            this.idConductor = -1;
            this.idCliente = -1;
        }

        public Carreras(taxiDataSet.carrerasRow regCarreras)
        {
            this.idCarrera = regCarreras.idCarrera;
            this.origen = regCarreras.origen;
            this.destino = regCarreras.destino;
            this.fecha = regCarreras.fecha;
            this.metros = regCarreras.metros;
            this.duracion = regCarreras.duracion;
            this.idTarifa = regCarreras.idTarifa;
            this.idConductor = regCarreras.idConductor;
            this.idCliente = regCarreras.idCliente;
        }

        public int IdCarrera
        {
            get
            {
                return idCarrera;
            }

            set
            {
                idCarrera = value;
            }
        }

        public string Origen
        {
            get
            {
                return origen;
            }

            set
            {
                origen = value;
            }
        }

        public string Destino
        {
            get
            {
                return destino;
            }

            set
            {
                destino = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public int Metros
        {
            get
            {
                return metros;
            }

            set
            {
                metros = value;
            }
        }

        public int Duracion
        {
            get
            {
                return duracion;
            }

            set
            {
                duracion = value;
            }
        }

        public int IdTarifa
        {
            get
            {
                return idTarifa;
            }

            set
            {
                idTarifa = value;
            }
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
    }
}
