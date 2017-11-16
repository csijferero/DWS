using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace TiendaBasica
{
    class Tienda
    {
        //Para guardar los Movimientos

        //Campos
        string nombre;
        double saldo;

        public Tienda(string nombre, double saldo)
        {
            this.nombre = nombre;
            this.saldo = saldo;
        }

        #region Propiedades

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public double Saldo
        {
            get
            {
                return saldo;
            }

            set
            {
                saldo = value;
            }
        }

        #endregion

        public void PresentaMovis(Movimiento mov)
        {
            Console.WriteLine("\n--------- LISTA DE MOVIMIENTOS. Saldo: {0} ----------\n", saldo);
            Console.Write("\tNº\tFechaM\tC/V\tArticulo\tCant.\tEuros\n");
            Console.Write("\t--\t------\t---\t--------\t-----\t-------\n");
            //for (int i = 0; i < ; i++)
            //{
            //}

        }
    }
}
