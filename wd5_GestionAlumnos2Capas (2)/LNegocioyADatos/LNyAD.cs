using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LNegocioyADatos.DataSet1TableAdapters;

namespace LNegocioyADatos
{
    public class LNyAD
    {
        // Construimos los adaptadores y tablas que necesitamos
        static GruposTableAdapter gruposAdapter = new GruposTableAdapter();
        static DataSet1.GruposDataTable gruposTabla = new DataSet1.GruposDataTable();

        static AlumnosTableAdapter alumnosAdapter = new AlumnosTableAdapter();
        static DataSet1.AlumnosDataTable alumnosTabla = new DataSet1.AlumnosDataTable();

        static public List<Grupo> ListaGrupos()
        {
            List<Grupo> listaGrupos = new List<Grupo>();
            // cargamos la tabla de Grupos
            // gruposAdapt.Fill(gruposTabla);
            gruposTabla = gruposAdapter.GetData();

            foreach (DataSet1.GruposRow regGrupo in gruposTabla)
                listaGrupos.Add(new Grupo(regGrupo));

            return listaGrupos;
        }

        public static DataSet1.AlumnosDataTable TablaAlumnos(int idGrupo)
        {
            if (idGrupo == 0) //<-- Significa que hemos elegido "Todos los Grupos"
                alumnosTabla = alumnosAdapter.GetDataConAliasGrupo();
            else
            {
                // Hemos elegido un grupo de los existentes
                // Previamente añado al adaptador de alumnos el Select según grupo
                // ahora la uso
                alumnosTabla = alumnosAdapter.GetDataByIdGrupo(idGrupo);
            }

            return alumnosTabla;
        }
    }
}
