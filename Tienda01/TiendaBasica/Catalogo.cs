using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaBasica
{
    static class Catalogo
    {
        // Para guardar los Articulos (productos o alimentos)

        static List<Producto> listaCatalogo = new List<Producto>();

        public static List<Producto> ListaCatalogo
        {
            get
            {
                return listaCatalogo;
            }

            set
            {
                listaCatalogo = value;
            }
        }

        public static void PresentaArticulos()
        {
            Console.WriteLine("\n--------- PRESENTACION LISTA DE ARTICULOS ----------\n");
            Console.WriteLine("\tId  Nombre\tCant\tCosto\tPVP \tCaducidad\n");
            Console.WriteLine("\t--  ------\t----\t-----\t----\t---------\n");
            for (int i = 0; i < listaCatalogo.Count; i++)
            {
                Console.Write("\t{0}  ", (i + 1));
                listaCatalogo[i].mostrar();
            }
        }
    }
}
