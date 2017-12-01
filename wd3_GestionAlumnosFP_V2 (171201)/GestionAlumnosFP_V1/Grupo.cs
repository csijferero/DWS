using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAlumnosFP_V1
{
    public class Grupo
    {
        //Campos

        int idgrupo;
        string alias;
        string nombre;
        string idtutor;
        string iddpto;

        //Constructor
        public Grupo()
        {
            this.idgrupo = -1;
            this.alias = String.Empty;
            this.nombre = String.Empty;
            this.idtutor = String.Empty;
            this.iddpto = String.Empty;
        }

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
            this.idtutor = regGrupo.idTutor;
            this.iddpto = regGrupo.idDpto;
        }

        public Grupo(int idgrupo, string alias, string nombre, string idtutor, string iddpto)
        {
            this.idgrupo = idgrupo;
            this.alias = alias;
            this.nombre = nombre;
            this.idtutor = idtutor;
            this.iddpto = iddpto;
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

        public string Idtutor
        {
            get
            {
                return idtutor;
            }

            set
            {
                idtutor = value;
            }
        }

        public string Iddpto
        {
            get
            {
                return iddpto;
            }

            set
            {
                iddpto = value;
            }
        }
    }
}
