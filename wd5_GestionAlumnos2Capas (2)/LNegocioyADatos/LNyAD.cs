﻿using System;
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

        public static void BorarRegistro(int idAlumno)
        {
            // Obtengo el registro correspondiente a dicho alumno
            DataSet1.AlumnosRow regAlumno = LNyAD.alumnosTabla.FindByidAlumno(idAlumno);

            // elimino el registro
            regAlumno.Delete();

            // actualizo la BD
            LNyAD.alumnosAdapter.Update(regAlumno);

        }

        public static Alumno ObtenerRegistro(int idAlumno)
        {
            // Obtengo el registro correspondiente a dicho alumno
            DataSet1.AlumnosRow regAlumno = alumnosTabla.FindByidAlumno(idAlumno);

            // Construimos el alumnos a editar
            Alumno alum = new Alumno(regAlumno);

            return alum;
        }

        public static void EditRegistro(Alumno alum)
        {
            // Obtengo el registro correspondiente a dicho alumno
            DataSet1.AlumnosRow regAlumno = alumnosTabla.FindByidAlumno(alum.IdAlumno);


            // actualizo el registro
            regAlumno.apellidosNombre = alum.ApellidosNombre;
            regAlumno.dni = alum.Dni;
            regAlumno.movil = alum.Movil;
            regAlumno.telefono = alum.Telefono;
            regAlumno.email = alum.Email;
            regAlumno.idGrupo = alum.IdGrupo;

            // actualizo la bd
            alumnosAdapter.Update(regAlumno);
        }
    }
}
