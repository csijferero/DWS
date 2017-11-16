using System;

namespace TiendaBasica
{
    class Alimento:Producto
    {
        int fechaCad;   // Fecha caducidad. 6 cifras (AAMMDD)

        public Alimento(string nombre, double costo, int cantidad, int fechaCad) :
            base(nombre, costo, 50, cantidad)
        {
            this.fechaCad = fechaCad;
        }

        public Alimento(string nombre, double costo, int fechaCad) :
            base(nombre, costo)
        {
            this.fechaCad = fechaCad;
        }

        public int FechaCad
        {
            get
            {
                return fechaCad;
            }

            set
            {
                fechaCad = value;
            }
        }

        public override double PVP()
        {
            return 1.5 * Costo;
        }

        public override void mostrar()
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", Nombre, Cantidad, Costo, PVP(), FechaCad);
        }

    }
}

/*
    // Para calcular el PVP de un alimento se hará
       pvp = 1.2*costo; // (ojo: el PVP no es un campo) 
*/
