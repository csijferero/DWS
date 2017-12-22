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

        #region Listas para Combos
        static public List<Clientes> ListaClientes()
        {
            List<Clientes> listaClientes = new List<Clientes>();
            clientesTabla = clientesAdapter.GetData(); //Cargamos la lista

            foreach (taxiDataSet.clientesRow regClientes in clientesTabla)
                listaClientes.Add(new Clientes(regClientes)); //Añadimos en la lista los componentes de la BD
            return listaClientes;
        }
        static public List<Conductores> ListaConductores()
        {
            List<Conductores> listaConductores = new List<Conductores>();
            conductoresTabla = conductoresAdapter.GetData(); //Cargamos la lista

            foreach (taxiDataSet.conductoresRow regConductores in conductoresTabla)
                listaConductores.Add(new Conductores(regConductores)); //Añadimos en la lista los componentes de la BD
            return listaConductores;
        }
        static public List<Tarifas> ListaTarifas()
        {
            List<Tarifas> listaTarifas = new List<Tarifas>();
            tarifasTabla = tarifasAdapter.GetData(); //Cargamos la lista

            foreach (taxiDataSet.tarifasRow regTarifas in tarifasTabla)
                listaTarifas.Add(new Tarifas(regTarifas)); //Añadimos en la lista los componentes de la BD
            return listaTarifas;
        }
        #endregion

        #region Tablas y Filtros DGV
        static public taxiDataSet.clientesDataTable TablaClientes()
        {
            clientesTabla = clientesAdapter.GetData();
            return clientesTabla;
        }

        static public taxiDataSet.clientesDataTable ComprobarAsociacionCliente(int ID)
        {
            clientesTabla = clientesAdapter.ClienteAsociado(ID);
            return clientesTabla;
        }

        static public taxiDataSet.clientesDataTable TablaClientesDNI(string DNI)
        {
            clientesTabla = clientesAdapter.BuscarPorDNI('%' + DNI + '%');
            return clientesTabla;
        }

        static public taxiDataSet.conductoresDataTable TablaConductores()
        {
            conductoresTabla = conductoresAdapter.GetData();
            return conductoresTabla;
        }

        static public taxiDataSet.conductoresDataTable ComprobarAsociacionConductor(int ID)
        {
            conductoresTabla = conductoresAdapter.CondctorAsociado(ID);
            return conductoresTabla;
        }

        static public taxiDataSet.conductoresDataTable TablaConductoresDNI(string DNI)
        {
            conductoresTabla = conductoresAdapter.BuscarPorDNI(DNI);
            return conductoresTabla;
        }

        static public taxiDataSet.conductoresDataTable TablaConductoresMatricula(string matricula)
        {
            conductoresTabla = conductoresAdapter.BuscarPorMatricula('%' + matricula + '%');
            return conductoresTabla;
        }

        static public taxiDataSet.tarifasDataTable TablaTarifas()
        {
            tarifasTabla = tarifasAdapter.GetData();
            return tarifasTabla;
        }

        static public taxiDataSet.tarifasDataTable ComprobarAsociacionTarifa(int ID)
        {
            tarifasTabla = tarifasAdapter.TarifaAsociada(ID);
            return tarifasTabla;
        }

        static public taxiDataSet.tarifasDataTable TablaTarifasNumero(decimal numero)
        {
            tarifasTabla = tarifasAdapter.BuscarPorNumero(numero);
            return tarifasTabla;
        }

        static public taxiDataSet.carrerasDataTable TablaCarreras()
        {
            carrerasTabla = carrerasAdapter.GetCarrerasMOD();
            return carrerasTabla;
        }

        static public taxiDataSet.carrerasDataTable TablaCarrerasFecha(DateTime fecha)
        {
            carrerasTabla = carrerasAdapter.BuscarPorFecha(fecha);
            return carrerasTabla;
        }
        #endregion

        #region Operaciones con el Usuario
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

        static public List<Usuarios> BuscaAdmin()
        {
            List<Usuarios> listaUsuarios = new List<Usuarios>();
            usuariosTabla = usuariosAdapter.BuscaAdmin();

            foreach (taxiDataSet.usuariosRow regUsuarios in usuariosTabla)
                listaUsuarios.Add(new Usuarios(regUsuarios));

            return listaUsuarios;
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
        #endregion

        #region Obtener Tipos

        static public Clientes ObtenerCliente(int idCliente)
        {
            Clientes cliente = null;
            clientesTabla = clientesAdapter.BuscarPorId(idCliente);

            taxiDataSet.clientesRow regCliente = clientesTabla[0];
            cliente = new Clientes(regCliente);

            return cliente;
        }
        static public Tarifas ObtenerTarifa(int idTarifa)
        {
            Tarifas tarifa = null;
            tarifasTabla = tarifasAdapter.BuscarPorId(idTarifa);

            taxiDataSet.tarifasRow regCliente = tarifasTabla[0];
            tarifa = new Tarifas(regCliente);

            return tarifa;
        }
        static public Conductores ObtenerConductor(int idConductor)
        {
            Conductores conductor = null;
            conductoresTabla = conductoresAdapter.BuscarPorId(idConductor);

            taxiDataSet.conductoresRow regConductor = conductoresTabla[0];
            conductor = new Conductores(regConductor);

            return conductor;
        }
        static public Carreras obtenerCarrera(int idCarrera)
        {
            Carreras carrera = null;
            carrerasTabla = carrerasAdapter.BuscarPorId(idCarrera);

            taxiDataSet.carrerasRow regCarreras = carrerasTabla[0];
            carrera = new Carreras(regCarreras);

            return carrera;
        }

        #endregion

        #region Editar Tipos

        static public void EditarCarrera(Carreras car)
        {
            taxiDataSet.carrerasRow regCarrera;

            if (car.IdCarrera != -1) //Obtengo el registro de la carrera a editar
            {
                carrerasTabla = carrerasAdapter.BuscarPorId(car.IdCarrera);
                regCarrera = carrerasTabla[0];
            }
            else //Si es nueva añado
                regCarrera = carrerasTabla.NewcarrerasRow();

            //Realizo los cambios
            regCarrera.origen = car.Origen;
            regCarrera.destino = car.Destino;
            regCarrera.metros = car.Metros;
            regCarrera.duracion = car.Duracion;
            regCarrera.idTarifa = car.IdTarifa;
            regCarrera.idConductor = car.IdConductor;
            regCarrera.idCliente = car.IdCliente;
            regCarrera.fecha = car.Fecha;

            if (car.IdCarrera == -1) //Si es una carrera nueva la añado
                carrerasTabla.AddcarrerasRow(regCarrera);

            carrerasAdapter.Update(regCarrera); //Actualizo
        }

        static public void EditarTarifa(Tarifas tar)
        {
            taxiDataSet.tarifasRow regTarifa;

            if (tar.IdTarifa != -1) //Obtengo el registro de la tarifa a editar
            {
                tarifasTabla = tarifasAdapter.BuscarPorId(tar.IdTarifa);
                regTarifa = tarifasTabla[0];
            }
            else //Si es nueva añado
                regTarifa = tarifasTabla.NewtarifasRow();

            //Realizo los cambios
            regTarifa.idTarifa = tar.IdTarifa;
            regTarifa.numeroTarifa = tar.NumeroTarifa;
            regTarifa.precioBandera = tar.PrecioBandera;
            regTarifa.precioDuracion = tar.PrecioDuracion;
            regTarifa.precioMetros = tar.PrecioMetros;

            if (tar.IdTarifa == -1) //Si es una tarifa nueva la añado
                tarifasTabla.AddtarifasRow(regTarifa);

            tarifasAdapter.Update(regTarifa); //Actualizo
        }

        static public void EditarConductor(Conductores cond)
        {
            taxiDataSet.conductoresRow regConductor;

            if (cond.IdConductor != -1) //Obtengo el registro del conductor a editar
            {
                conductoresTabla = conductoresAdapter.BuscarPorId(cond.IdConductor);
                regConductor = conductoresTabla[0];
            }
            else //Si es nuevo añado
                regConductor = conductoresTabla.NewconductoresRow();

            //Realizo los cambios
            regConductor.idConductor = cond.IdConductor;
            regConductor.nombreConductor = cond.NombreConductor;
            regConductor.apellidosConductor = cond.ApellidosConductor;
            regConductor.direccionConductor = cond.DireccionConductor;
            regConductor.emailConductor = cond.EmailConductor;
            regConductor.dniConductor = cond.DniConductor;
            regConductor.licenciaConductor = cond.LicenciaConductor;
            regConductor.matriculaConductor = cond.MatriculaConductor;

            if (cond.IdConductor == -1) //Si es un conductor nuevo lo añado
                conductoresTabla.AddconductoresRow(regConductor);

            conductoresAdapter.Update(regConductor); //Actualizo
        }

        static public void EditarCliente(Clientes client)
        {
            taxiDataSet.clientesRow regClientes;

            if (client.IdCliente != -1) //Obtengo el registro del cliente a a editar
            {
                clientesTabla = clientesAdapter.BuscarPorId(client.IdCliente);
                regClientes = clientesTabla[0];
            }
            else //Si es nuevo añado
                regClientes = clientesTabla.NewclientesRow();

            //Realizo los cambios
            regClientes.idCliente = client.IdCliente;
            regClientes.nombreCliente = client.NombreCliente;
            regClientes.apellidosCliente = client.ApellidosCliente;
            regClientes.direccionCliente = client.DireccionCliente;
            regClientes.emailCliente = client.EmailCliente;
            regClientes.dniCliente = client.DniCliente;

            if (client.IdCliente == -1) //Si es un cliente nuevo lo añado
                clientesTabla.AddclientesRow(regClientes);

            clientesAdapter.Update(regClientes); //Actualizo
        }

#endregion

        #region Borrar Tipos

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

        #endregion

    }
}
