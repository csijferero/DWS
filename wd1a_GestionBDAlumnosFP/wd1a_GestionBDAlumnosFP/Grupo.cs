using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wd1a_GestionBDAlumnosFP
{
    class Grupo
    {
        int idGrupo;
        string alias;
        string nombre;

        public Grupo(int idGrupo, string alias, string nombre)
        {
            this.idGrupo = idGrupo;
            this.alias = alias;
            this.nombre = nombre;
        }

        public int IdGrupo
        {
            get
            {
                return idGrupo;
            }

            set
            {
                idGrupo = value;
            }
        }

        public string Alias
        {
            get
            {
                return alias;
            }

            set
            {
                alias = value;
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
    }
}
