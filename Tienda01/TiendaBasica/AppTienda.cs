using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaBasica
{
    class AppTienda
    {
        static void Main(string[] args)
        {

            double saldo = 6000;       // <-- Euros de los que parte la aplicación
            int fechaMovis = 110102;   // <-- Se supone la fecha de las compras/ventas que hagas
            int opcion = 0;
            //--- Variables auxiliares para los formularios
            int id, cantidad;
            bool esAlimento = false;
            string nombre = "Tienda2017";
            double costo = 0;
            string nombreArticulo = "";
            List<Movimiento> listaMovimientos = new List<Movimiento>();

            // Productos inicales
            Catalogo.ListaCatalogo.Add(new Producto("Balón Fut.", 10.5, 20, 20));
            Catalogo.ListaCatalogo.Add(new Producto("Grapadora", 5.5));
            Catalogo.ListaCatalogo.Add(new Alimento("Naranjas", 1.5, 20, 110521));
            Catalogo.ListaCatalogo.Add(new Alimento("Manzanas", 2.3, 110221));
            Catalogo.ListaCatalogo.Add(new Producto("Cuaderno", 1.0, 20, 20));
            Catalogo.ListaCatalogo.Add(new Alimento("Melón Sapo", 2.3, 110221));

            Tienda tienda = new Tienda(nombre, saldo);

            //--- Entramos en el Menú
            do
            {
                opcion = Util.Menu();
                Console.Clear();
                switch (opcion)
                {
                    case 1:  // LISTAR CATÁLOGO

                        Console.WriteLine("SALDO ACTUAL: {0}\n\n", tienda.Saldo);

                        Catalogo.PresentaArticulos();

                        break;

                    case 2: // NUEVA FECHA DE MOVIMIENTOS

                        int nuevaFecha = Util.CapturaFecha();

                        if (nuevaFecha > fechaMovis)
                            fechaMovis = nuevaFecha;
                        else
                            Console.WriteLine(" ** LA FECHA INTRODUCIDA DEBE SER MAYOR QUE LA ANTERIOR.");

                        break;

                    case 3: // COMPRAR

                        cantidad = 0;
                        costo = 0;

                        Console.WriteLine("SALDO ACTUAL: {0}\n\n", tienda.Saldo);

                        Catalogo.PresentaArticulos();


                        id = Util.CapturaPulso("¿Id del artículo a comprar? [0=Nuevo]: ", 0, Catalogo.ListaCatalogo.Count) - 1; //Solicitamos ID
                        if (id == -1) //Proceso de creacion de nuevo producto
                        {
                            bool duplicado = false;
                            do //Comprobamos si el nuevo articulo ya existia
                            {
                                duplicado = false;
                                nombreArticulo = Util.CapturaCadena("¿Que nombre tiene el articulo?", 10);
                                for (int i = 0; i < Catalogo.ListaCatalogo.Count; i++)
                                {
                                    if (nombreArticulo.ToUpper().TrimEnd() == Catalogo.ListaCatalogo[i].Nombre.ToUpper())
                                    {
                                        duplicado = true;
                                        Console.WriteLine("\n\n\t\t ** ERROR ARTICULO DUPLICADO");
                                        Console.Beep(400, 400);
                                    }
                                }
                            } while (duplicado);
                            esAlimento = Util.CapturaSiNo("¿Es un alimento?");
                            costo = Util.CapturaDouble("¿Coste del artículo?", 1);
                            if (tienda.Saldo % costo <= tienda.Saldo) //Comprobamos cuantos articulos son posibles comprar (no existentes)
                                cantidad = Util.CapturaEntero("¿Cantidad a comprar?: ", 0, Convert.ToInt32(Math.Truncate(tienda.Saldo / costo)));
                            else
                                cantidad = Util.CapturaEntero("¿Cantidad a comprar?: ", 0, Convert.ToInt32(tienda.Saldo / costo) - 1);
                        }
                        else //Comprobamos cuantos articulos son posibles comprar (existentes)
                        {
                            if (tienda.Saldo % Catalogo.ListaCatalogo[id].Costo <= tienda.Saldo) //Comprobamos cuantos productos son posibles comprar (existentes)
                                cantidad = Util.CapturaEntero("¿Cantidad a comprar?: ", 0, Convert.ToInt32(Math.Truncate(tienda.Saldo / Catalogo.ListaCatalogo[id].Costo)));
                            else
                                cantidad = Util.CapturaEntero("¿Cantidad a comprar?: ", 0, Convert.ToInt32(tienda.Saldo / Catalogo.ListaCatalogo[id].Costo) - 1);
                        }
                        if (esAlimento && id == -1) //Añadir nuevo alimento
                        {
                            int fecha = Util.CapturaFecha();
                            Catalogo.ListaCatalogo.Add(new Alimento(nombreArticulo, costo, cantidad, fecha));
                        }
                        else if (id == -1) //añadir nuevo producto
                        {
                            int beneficio = Util.CapturaEntero("Introduzca la cantidad de beneficio [0=Omitir]", 0); //****?¿¿?¿?****
                            if (beneficio == 0)
                                Catalogo.ListaCatalogo.Add(new Producto(nombreArticulo, costo, cantidad));
                            else
                                Catalogo.ListaCatalogo.Add(new Producto(nombreArticulo, costo, beneficio, cantidad));
                        }
                        else if (id >= 0 && Catalogo.ListaCatalogo[id] is Alimento) //Actualizar Alimento
                        {
                            int fecha = Util.CapturaFecha();
                            Catalogo.ListaCatalogo[id].Cantidad += cantidad;
                            ((Alimento)Catalogo.ListaCatalogo[id]).FechaCad = fecha;
                        }
                        else //Actualizar Producto
                            Catalogo.ListaCatalogo[id].Cantidad += cantidad;

                        if (costo > 0) //ACTUALIZACION DE SALDO Y MOVIMIENTO (PRODUCTO NO EXISTENTE)
                        {
                            tienda.Saldo -= (cantidad * costo);
                            listaMovimientos.Add(new Movimiento(140102, 'C', Catalogo.ListaCatalogo.Count - 1, cantidad));
                        }
                        else //ACTUALIZACION DE SALDO Y MOVIMIENTO (PRODUCTO EXISTENTE)
                        {
                            tienda.Saldo -= (cantidad * Catalogo.ListaCatalogo[id].Costo);
                            listaMovimientos.Add(new Movimiento(fechaMovis, 'C', id, cantidad));
                        }


                        break;

                    case 4: // VENDER
                        cantidad = 0;
                        costo = 0;

                        Console.WriteLine("SALDO ACTUAL: {0}\n\n", tienda.Saldo);

                        Catalogo.PresentaArticulos();


                        id = Util.CapturaPulso("¿Id del artículo a vender?: ", 1, Catalogo.ListaCatalogo.Count) - 1; //Solicitamos ID

                        cantidad = Util.CapturaEntero("¿Cantidad a vender?: ", 0, Catalogo.ListaCatalogo[id].Cantidad);

                        Catalogo.ListaCatalogo[id].Cantidad -= cantidad;

                        tienda.Saldo += Catalogo.ListaCatalogo[id].PVP() * cantidad;

                        listaMovimientos.Add(new Movimiento(fechaMovis, 'V', id, cantidad));



                        break;


                    case 5: // LISTAR MOVIMIENTOS

                        Console.WriteLine("SALDO ACTUAL: {0}\n\n", tienda.Saldo);

                        Console.WriteLine("\tNº      FechaM\tC/V\tArtículo\tCant. \tEuros\n");
                        Console.WriteLine("        --      ------  ---     --------        -----   -----");

                        for (int i = 0; i < listaMovimientos.Count; i++)
                        {
                            Console.Write("\t" + (i + 1));
                            listaMovimientos[i].Presentar();
                        }
                        break;
                }

                Console.WriteLine("\n\n\t\tPulse una tecla para volver al menu");
                Console.ReadLine();


            } while (opcion != 0);
        }

    }
}
