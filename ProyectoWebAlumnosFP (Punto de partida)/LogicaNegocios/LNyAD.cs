using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaNegocios.DataSet1TableAdapters;

namespace LogicaNegocios
{
    public class LNyAD
    {
        static AlumnosTableAdapter alumnosAdapter = new AlumnosTableAdapter();
        static GruposTableAdapter gruposAdapter = new GruposTableAdapter();

        static DataSet1.AlumnosDataTable alumnosTabla = new DataSet1.AlumnosDataTable();
        static DataSet1.GruposDataTable gruposTabla = new DataSet1.GruposDataTable();

        static public List<Alumno> ListaAlumnos()
        {
            List<Alumno> listaAlumnos = new List<Alumno>();
            alumnosTabla = alumnosAdapter.GetData(); //Cargamos la lista

            foreach (DataSet1.AlumnosRow regAlumnos in alumnosTabla)
                listaAlumnos.Add(new Alumno(regAlumnos.idAlumno, regAlumnos.apellidosNombre, regAlumnos.dni, regAlumnos.idGrupo, regAlumnos.movil, regAlumnos.telefono, regAlumnos.email)); //Añadimos en la lista los componentes de la BD
            return listaAlumnos;
        }

        static public List<Grupo> ListaGrupos()
        {
            List<Grupo> listaGrupos = new List<Grupo>();
            gruposTabla = gruposAdapter.GetData(); //Cargamos la lista

            foreach (DataSet1.GruposRow regGrupos in gruposTabla)
                listaGrupos.Add(new Grupo(regGrupos.idGrupo, regGrupos.nombre, regGrupos.alias)); //Añadimos en la lista los componentes de la BD
            return listaGrupos;
        }
    }
}
