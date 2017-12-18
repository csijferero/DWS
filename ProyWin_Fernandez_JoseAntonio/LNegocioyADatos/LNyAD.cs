using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNegocioyADatos.taxiDataSetTableAdapters; //Dataset de la DB.

namespace LNegocioyADatos
{
    public class LNyAD
    {
        //ADAPTADORES Y TABLAS.
        static clientesTableAdapter clientesAdapter = new clientesTableAdapter();
        static taxiDataSet.clientesDataTable clientesTabla = new taxiDataSet.clientesDataTable();

        static usuariosTableAdapter usuariosAdapter = new usuariosTableAdapter();
        static taxiDataSet.usuariosDataTable usuariosTabla = new taxiDataSet.usuariosDataTable();

        static conductoresTableAdapter conductoresAdapter = new conductoresTableAdapter();
        static taxiDataSet.conductoresDataTable conductoresTabla = new taxiDataSet.conductoresDataTable();

        static tarifasTableAdapter tarifasAdapter = new tarifasTableAdapter();
        static taxiDataSet.tarifasDataTable tarifasTabla = new taxiDataSet.tarifasDataTable();

        static carrerasTableAdapter carrerasAdapter = new carrerasTableAdapter();
        static taxiDataSet.carrerasDataTable carrerasTabla = new taxiDataSet.carrerasDataTable();

        static public List<Clientes> listaClientes()
        {
            List<Clientes> listaClientes = new List<Clientes>();
            clientesTabla = clientesAdapter.GetData(); //Cargamos la lista

            foreach (taxiDataSet.clientesRow regClientes in clientesTabla)
                listaClientes.Add(new Clientes(regClientes)); //Añadimos en la lista los componentes de la BD
            return listaClientes;
        }

        static public taxiDataSet.clientesDataTable tablaClientes()
        {
            clientesTabla = clientesAdapter.GetData();
            return clientesTabla;
        }

        static public taxiDataSet.conductoresDataTable tablaConductores()
        {
            conductoresTabla = conductoresAdapter.GetData();
            return conductoresTabla;
        }

        static public taxiDataSet.tarifasDataTable tablaTarifas()
        {
            tarifasTabla = tarifasAdapter.GetData();
            return tarifasTabla;
        }

        static public taxiDataSet.carrerasDataTable tablaCarreras()
        {
            carrerasTabla = carrerasAdapter.GetCarrerasMOD();
            return carrerasTabla;
        }

        static public Usuarios buscaUsuario(string user, string clave)
        {
            Usuarios usuario = null;
            usuariosTabla = usuariosAdapter.BuscarPorNombreClave(user, clave);
            foreach (taxiDataSet.usuariosRow regUsuarios in usuariosTabla) //?¿?¿?¿
                usuario = new Usuarios(regUsuarios);
            return usuario;
        }
    }
}
