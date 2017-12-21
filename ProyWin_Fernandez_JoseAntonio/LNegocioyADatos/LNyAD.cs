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

        static public List<Clientes> ListaClientes()
        {
            List<Clientes> listaClientes = new List<Clientes>();
            clientesTabla = clientesAdapter.GetData(); //Cargamos la lista

            foreach (taxiDataSet.clientesRow regClientes in clientesTabla)
                listaClientes.Add(new Clientes(regClientes)); //Añadimos en la lista los componentes de la BD
            return listaClientes;
        }

        static public taxiDataSet.clientesDataTable TablaClientes()
        {
            clientesTabla = clientesAdapter.GetData();
            return clientesTabla;
        }

        static public taxiDataSet.conductoresDataTable TablaConductores()
        {
            conductoresTabla = conductoresAdapter.GetData();
            return conductoresTabla;
        }

        static public taxiDataSet.tarifasDataTable TablaTarifas()
        {
            tarifasTabla = tarifasAdapter.GetData();
            return tarifasTabla;
        }

        static public taxiDataSet.carrerasDataTable TablaCarreras()
        {
            carrerasTabla = carrerasAdapter.GetCarrerasMOD();
            return carrerasTabla;
        }

        static public Usuarios BuscaUsuario(string user, string clave)
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

        static public Usuarios BuscaLogin(string login)
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

        static public Usuarios BuscaAlias(string alias)
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

        static public void AgregarUsuario(string nombre, string alias, string login, string clave)
        {
            usuariosAdapter.AgregarUsuario(0, alias, clave, login, nombre);
        }

        static public Usuarios ObtenerUsuario(int idUsuario)
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

        static public List<Usuarios> BuscaAdmin()
        {
            List<Usuarios> listaUsuarios = new List<Usuarios>();
            usuariosTabla = usuariosAdapter.BuscaAdmin();

            foreach (taxiDataSet.usuariosRow regUsuarios in usuariosTabla)
                listaUsuarios.Add(new Usuarios(regUsuarios));

            return listaUsuarios;
        }

        static public void EditarUsuario(Usuarios usu)
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

        public static void BorarUsuario(int idUsuario)
        {
            // Obtengo el registro del usuario a eliminar
            usuariosTabla = usuariosAdapter.BuscarPorId(idUsuario);

            taxiDataSet.usuariosRow regUsuario = usuariosTabla[0];

            // elimino el registro
            regUsuario.Delete();

            // actualizo la BD
            LNyAD.usuariosAdapter.Update(regUsuario);
        }

        public static void BorarCliente(int idCliente)
        {
            // Obtengo el registro del cliente a eliminar
            clientesTabla = clientesAdapter.BuscarPorId(idCliente);

            taxiDataSet.clientesRow regCliente = clientesTabla[0];

            // elimino el registro
            regCliente.Delete();

            // actualizo la BD
            LNyAD.clientesAdapter.Update(regCliente);
        }

        public static void BorarTarifa(int idTarifa)
        {
            // Obtengo el registro de la tarifa a eliminar
            tarifasTabla = tarifasAdapter.BuscarPorId(idTarifa);

            taxiDataSet.tarifasRow regTarifa = tarifasTabla[0];

            // elimino el registro
            regTarifa.Delete();

            // actualizo la BD
            LNyAD.tarifasAdapter.Update(regTarifa);
        }
        public static void BorarConductor(int idConductor)
        {
            // Obtengo el registro del conductor a eliminar
            conductoresTabla = conductoresAdapter.BuscarPorId(idConductor);

            taxiDataSet.conductoresRow regConductor = conductoresTabla[0];

            // elimino el registro
            regConductor.Delete();

            // actualizo la BD
            LNyAD.conductoresAdapter.Update(regConductor);
        }
        public static void BorarCarrera(int idCarrera)
        {
            // Obtengo el registro de la carrera a eliminar
            carrerasTabla = carrerasAdapter.BuscarPorId(idCarrera);

            taxiDataSet.carrerasRow regCarrera = carrerasTabla[0];

            // elimino el registro
            regCarrera.Delete();

            // actualizo la BD
            LNyAD.carrerasAdapter.Update(regCarrera);
        }

        static public taxiDataSet.usuariosDataTable TablaUsuarios()
        {
            usuariosTabla = usuariosAdapter.GetData();
            return usuariosTabla;
        }

        static public taxiDataSet.usuariosDataTable TablaUsuarios(int idUsuario)
        {
            usuariosTabla = usuariosAdapter.BuscarPorId(idUsuario);
            return usuariosTabla;
        }

    }
}
