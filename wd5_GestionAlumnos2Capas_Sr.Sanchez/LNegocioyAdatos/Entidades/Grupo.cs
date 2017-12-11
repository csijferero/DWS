using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNegocioyAdatos
{
    public class Grupo
    {
        //Campos

        int idgrupo;
        string alias;
        string nombre;

        //Constructor

        public Grupo(int idgrupo, string alias, string nombre)
        {
            this.idgrupo = idgrupo;
            this.alias = alias;
            this.nombre = nombre;
        }

        public Grupo(DataSet1.GruposRow regGrupo)
        {
            this.idgrupo = regGrupo.idGrupo;
            this.alias = regGrupo.alias;
            this.nombre = regGrupo.nombre;
        }

        //Propiedades

        public int Idgrupo
        {
            set { idgrupo = value; }
            get { return idgrupo; }
        }

        public string Alias
        {
            set { alias = value; }
            get { return alias; }
        }

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
    }
}
