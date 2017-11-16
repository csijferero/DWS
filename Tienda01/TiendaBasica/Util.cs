// Nota: Lo que tienes escrito aquí es orientativo. Puedes quitar o poner lo que te interese.

using System;

namespace TiendaBasica
{
    public class Util
    {
        //----DEVUELVE LA OPCION SELECCIONADA
        public static int Menu()
        {
            int opcion;
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("\t\t\t+--------------------------------+ ");
            Console.WriteLine("\t\t\t|             MENU               | ");
            Console.WriteLine("\t\t\t+--------------------------------+ ");
            Console.WriteLine("\t\t\t|                                | ");
            Console.WriteLine("\t\t\t|    1) Listar Catálogo          | ");
            Console.WriteLine("\t\t\t|                                | ");
            Console.WriteLine("\t\t\t|    2) Fecha de Movimientos     | ");
            Console.WriteLine("\t\t\t|                                | ");
            Console.WriteLine("\t\t\t|    3) Comprar Artículo         | ");
            Console.WriteLine("\t\t\t|                                | ");
            Console.WriteLine("\t\t\t|    4) Vender Articulo          | ");
            Console.WriteLine("\t\t\t|                                | ");
            Console.WriteLine("\t\t\t|    5) Listar Movimientos       | ");
            Console.WriteLine("\t\t\t|                                | ");
            Console.WriteLine("\t\t\t+--------------------------------+ ");
            Console.WriteLine("\t\t\t|         0) Salir               | ");
            Console.WriteLine("\t\t\t+--------------------------------+ ");

            opcion = CapturaPulso("Introduzca opción: ", 0, 5);

            return opcion;
        }


        public static int CapturaEntero(string enunciado, int min, int max)
        {
            int valor = 0;
            bool esCorrecto = false;

            do
            {
                Console.Write("\n\n\t\t{0} [{1}-{2}]: ", enunciado, min, max);
                esCorrecto = Int32.TryParse(Console.ReadLine(), out valor);
                if (!esCorrecto || valor < min || valor > max)
                {
                    Console.WriteLine(" ** NO VALIDO. ({0} a {1})", min, max);
                    Console.Beep(400, 400);
                }
            } while (!esCorrecto || valor < min || valor > max);

            return valor;
        }

        public static int CapturaEntero(string enunciado, int min)
        {
            int valor = 0;
            bool esCorrecto = false;

            do
            {
                Console.Write("\n\n\t\t{0} [Mínimo {1}]: ", enunciado, min);
                esCorrecto = Int32.TryParse(Console.ReadLine(), out valor);
                if (!esCorrecto || valor < min)
                {
                    Console.WriteLine(" ** VALOR FUERA DE RANGO");
                    Console.Beep(400, 400);
                }
            } while (!esCorrecto || valor < min);

            return valor;
        }


        public static double CapturaDouble(string enunciado, int min)
        {
            double valor = 0;
            bool esCorrecto = false;

            do
            {
                Console.Write("\n\n\t\t{0} [Mínimo {1}]: ", enunciado, min);
                esCorrecto = Double.TryParse(Console.ReadLine(), out valor);
                if (!esCorrecto || valor < min)
                {
                    Console.WriteLine(" ** VALOR ERRONEO");
                    Console.Beep(400, 400);
                }
            } while (!esCorrecto || valor < min);

            return valor;
        }

        // Devuelve una fecha en formato AAMMDD
        public static int CapturaFecha()
        {
            int fecha;
            int limite = 0;
            string prueba;

            int año = CapturaEntero("Introduzca el Año", 11, 20);
            int mes = CapturaEntero("Introduzca el Mes", 1, 12);
            if (mes == 1 || mes == 3 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                limite = 31;
            }
            else
                limite = 30;
            int dia = CapturaEntero("Introduzca el dia", 1, limite);
            prueba = (año.ToString() + mes.ToString("00") + dia.ToString("00"));
            fecha = Convert.ToInt32(prueba);
            return fecha;
        }

        public static string CapturaCadena(string enunciado, int tamaño)
        {
            string cadena;
            do
            {
                Console.Write("\n\n\t\t" + enunciado + ": ");
                cadena = Console.ReadLine();
                if (cadena == "")
                {
                    Console.WriteLine(" ** INTRODUZCA UNA CADENA VALIDA");
                    Console.Beep(400, 400);
                }
                else
                    cadena = cadena + "                                                 ";
            } while (cadena == "");

            return cadena.Substring(0, tamaño);
        }

        public static bool CapturaSiNo(string enunciado)
        {
            ConsoleKeyInfo tecla;
            char letra;

            do
            {
                Console.Write("\n\n\t\t" + enunciado + " [S/N]: ");
                tecla = Console.ReadKey();
                letra = tecla.KeyChar;
                Console.WriteLine();
                if (letra != 'S' && letra != 'N' && letra != 's' && letra != 'n')
                {
                    Console.WriteLine(" ** TECLA ERRONEA");
                    Console.Beep(400, 400);
                }
            } while (letra != 'S' && letra != 'N' && letra != 's' && letra != 'n');

            if (letra == 'S' || letra == 's')
                return true;
            else
                return false;
        }

        public static int CapturaPulso(string mensaje, int min, int max)
        {
            char letra;


            int valor = 0;
            bool esCorrecto = false;
            do
            {
                Console.Write("\n\n\t\t{0} ({1}..{2}): ", mensaje, min, max);
                letra = Console.ReadKey().KeyChar;
                Console.WriteLine();
                esCorrecto = Int32.TryParse(Convert.ToString(letra), out valor);//el usuario escribe algo y pulsa INTRO
                if (!esCorrecto || valor < min || valor > max)
                {
                    Console.WriteLine(" ** NO VALIDO. ({0} a {1})", min, max);
                    Console.Beep(400, 400);
                }
            }
            while (!esCorrecto || valor < min || valor > max);


            return valor;
        }

    }
}
