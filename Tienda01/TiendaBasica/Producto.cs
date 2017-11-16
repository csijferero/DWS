using System;

namespace TiendaBasica
{

    class Producto
    {	//--- Los campos 
        string nombre; // Nombre del producto
        double costo;  // Cuánto le cuesta a la tienda la unidad (Sin IVA)
        int beneficio;  // Qué porcentaje se le gana a este producto
        int cantidad;  // Cantidad que tenemos de dicho producto

        #region Constructores
        public Producto(string nombre, double costo, int beneficio, int cantidad)
        {
            this.nombre = nombre;
            this.costo = costo;
            this.beneficio = beneficio;
            this.cantidad = cantidad;
        }

        public Producto(string nombre, double costo, int cantidad)
        {
            this.nombre = nombre;
            this.costo = costo;
            this.beneficio = 50;
            this.cantidad = cantidad;
        }

        public Producto(string nombre, double costo)
        {
            this.nombre = nombre;
            this.costo = costo;
            this.beneficio = 50;
            this.cantidad = 10;
        }
        #endregion

        #region Las Propiedades
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

        public double Costo
        {
            get
            {
                return costo;
            }

            set
            {
                costo = value;
            }
        }

        public int Beneficio
        {
            get
            {
                return beneficio;
            }

            set
            {
                beneficio = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }
        #endregion

        //--- Los Métodos

        public virtual double PVP()
        {
            double pvp = beneficio * costo / 100 + costo;
            return pvp;
        }

        public virtual void mostrar()
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t", Nombre, Cantidad, Costo, PVP());
        }
    }
}

/*
    // Para calcular el PVP de un producto se hará
       pvp = 1.5*costo; // (ojo: el PVP no es un campo) 
    // Para Presentar el producto puede que te haga falta esto...
       Console.WriteLine(" {0}	 {1}\t{2}\t{3}", nombre, cantidad, costo, PVP());
*/
