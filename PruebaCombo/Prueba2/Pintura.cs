using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Prueba2
{
    class Pintura
    {
        Color color;
        string nombre;
        double precio;

        public Pintura(Color color, string nombre, double precio)
        {
            this.color = color;
            this.nombre = nombre;
            this.precio = precio;
        }

        public Color _Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

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

        public double Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }
    }
}
