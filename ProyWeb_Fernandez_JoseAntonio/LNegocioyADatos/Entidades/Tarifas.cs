using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNegocioyADatos
{
    public class Tarifas
    {
        int idTarifa;
        double numeroTarifa;
        double precioBandera;
        double precioDuracion;
        double precioMetros;

        public Tarifas(int idTarifa, double numeroTarifa, double precioBandera, double precioDuracion, double precioMetros)
        {
            this.idTarifa = idTarifa;
            this.numeroTarifa = numeroTarifa;
            this.precioBandera = precioBandera;
            this.precioDuracion = precioDuracion;
            this.precioMetros = precioMetros;
        }

        public Tarifas()
        {
            this.idTarifa = -1;
            this.numeroTarifa = -1;
            this.precioBandera = -1;
            this.precioDuracion = -1;
            this.precioMetros = -1;
        }

        public Tarifas(taxiDataSet.tarifasRow regTarifas)
        {
            this.idTarifa = regTarifas.idTarifa;
            this.numeroTarifa = regTarifas.numeroTarifa;
            this.precioBandera = regTarifas.precioBandera;
            this.precioDuracion = regTarifas.precioDuracion;
            this.precioMetros = regTarifas.precioMetros;
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

        public double NumeroTarifa
        {
            get
            {
                return numeroTarifa;
            }

            set
            {
                numeroTarifa = value;
            }
        }

        public double PrecioBandera
        {
            get
            {
                return precioBandera;
            }

            set
            {
                precioBandera = value;
            }
        }

        public double PrecioDuracion
        {
            get
            {
                return precioDuracion;
            }

            set
            {
                precioDuracion = value;
            }
        }

        public double PrecioMetros
        {
            get
            {
                return precioMetros;
            }

            set
            {
                precioMetros = value;
            }
        }
    }
}
