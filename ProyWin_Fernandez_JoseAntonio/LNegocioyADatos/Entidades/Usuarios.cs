using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNegocioyADatos
{
    public class Usuarios
    {
        int idUsuario;
        string nombreUsuario;
        string aliasUsuario;
        string loginUsuario;
        string claveUsuario;
        int accesoUsuario;

        public Usuarios(int idUsuario, string nombreUsuario, string aliasUsuario, string loginUsuario, string claveUsuario, int accesoUsuario)
        {
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.aliasUsuario = aliasUsuario;
            this.loginUsuario = loginUsuario;
            this.claveUsuario = claveUsuario;
            this.accesoUsuario = accesoUsuario;
        }

        public Usuarios(taxiDataSet.usuariosRow regUsuarios)
        {
            this.idUsuario = regUsuarios.idUsuario;
            this.nombreUsuario = regUsuarios.nombreUsuario;
            this.aliasUsuario = regUsuarios.aliasUsuario;
            this.loginUsuario = regUsuarios.loginUsuario;
            this.claveUsuario = regUsuarios.claveUsuario;
            this.accesoUsuario = regUsuarios.accesoUsuario;
        }
        public int IdUsuario
        {
            get
            {
                return idUsuario;
            }

            set
            {
                idUsuario = value;
            }
        }

        public string NombreUsuario
        {
            get
            {
                return nombreUsuario;
            }

            set
            {
                nombreUsuario = value;
            }
        }

        public string AliasUsuario
        {
            get
            {
                return aliasUsuario;
            }

            set
            {
                aliasUsuario = value;
            }
        }

        public string LoginUsuario
        {
            get
            {
                return loginUsuario;
            }

            set
            {
                loginUsuario = value;
            }
        }

        public string ClaveUsuario
        {
            get
            {
                return claveUsuario;
            }

            set
            {
                claveUsuario = value;
            }
        }

        public int AccesoUsuario
        {
            get
            {
                return accesoUsuario;
            }

            set
            {
                accesoUsuario = value;
            }
        }
    }
}
