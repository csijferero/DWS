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

            if (usuariosTabla.Count != 0)
            {
                taxiDataSet.usuariosRow regUsuarios = usuariosTabla[0];
                usuario = new Usuarios(regUsuarios);
            }

            return usuario;
        }

        static public Usuarios buscaLogin(string login)
        {
            Usuarios usuario = null;
            usuariosTabla = usuariosAdapter.BuscarPorLogin(login);

            if (usuariosTabla.Count != 0)
            {
                taxiDataSet.usuariosRow regUsuarios = usuariosTabla[0];
                usuario = new Usuarios(regUsuarios);
            }

            return usuario;
        }

        static public Usuarios buscaAlias(string alias)
        {
            Usuarios usuario = null;
            usuariosTabla = usuariosAdapter.BuscarPorAlias(alias);

            if (usuariosTabla.Count != 0)
            {
                taxiDataSet.usuariosRow regUsuarios = usuariosTabla[0];
                usuario = new Usuarios(regUsuarios);
            }

            return usuario;
        }

        static public void agregarUsuario(string nombre, string alias, string login, string clave)
        {
            usuariosAdapter.AgregarUsuario(0, alias, clave, login, nombre);
        }

        static public Usuarios obtenerUsuario(int idUsuario)
        {
            Usuarios usuario = null;
            usuariosTabla = usuariosAdapter.BuscarPorId(idUsuario);

            if (usuariosTabla.Count != 0)
            {
                taxiDataSet.usuariosRow regUsuarios = usuariosTabla[0];
                usuario = new Usuarios(regUsuarios);
            }

            return usuario;
        }

        static public List<Usuarios> buscaAdmin()
        {
            List<Usuarios> listaUsuarios = new List<Usuarios>();
            usuariosTabla = usuariosAdapter.BuscaAdmin();

            foreach (taxiDataSet.usuariosRow regUsuarios in usuariosTabla)
                listaUsuarios.Add(new Usuarios(regUsuarios));

            return listaUsuarios;
        }

        static public void editarUsuario(Usuarios usu)
        {
            //obtrengo el registro del usuario a editar
            usuariosTabla = usuariosAdapter.BuscarPorId(usu.IdUsuario);
            taxiDataSet.usuariosRow regUsuario = usuariosTabla[0];

            //Realizo los cambios
            regUsuario.nombreUsuario = usu.NombreUsuario;
            regUsuario.aliasUsuario = usu.AliasUsuario;
            regUsuario.loginUsuario = usu.LoginUsuario;
            regUsuario.accesoUsuario = usu.AccesoUsuario;
            regUsuario.claveUsuario = usu.ClaveUsuario;

            usuariosAdapter.Update(regUsuario);

        }

        static public taxiDataSet.usuariosDataTable tablaUsuarios()
        {
            usuariosTabla = usuariosAdapter.GetData();
            return usuariosTabla;
        }

        static public taxiDataSet.usuariosDataTable tablaUsuarios(int idUsuario)
        {
            usuariosTabla = usuariosAdapter.BuscarPorId(idUsuario);
            return usuariosTabla;
        }

    }
}
