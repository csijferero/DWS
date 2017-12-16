using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNegocioyAdatos
{
    public class Alumno
    {
        int idAlumno;
        int idGrupo;
        string apellidosNombre;
        string dni;
        string movil;
        string telefono;
        string email;

        public Alumno()
        {
            this.idAlumno = -1;
            this.idGrupo = -1;
            this.apellidosNombre = String.Empty;
            this.dni = String.Empty;
            this.movil = String.Empty;
            this.telefono = String.Empty;
            this.email = String.Empty;
        }

        public Alumno(int idAlumno, int idGrupo, string apellidosNombre, string dni, string movil, string telefono, string email)
        {
            this.idAlumno = idAlumno;
            this.idGrupo = idGrupo;
            this.apellidosNombre = apellidosNombre;
            this.dni = dni;
            this.movil = movil;
            this.telefono = telefono;
            this.email = email;
        }

        public Alumno(DataSet1.AlumnosRow regAlumno)
        {
            this.idAlumno = regAlumno.idAlumno;
            this.idGrupo = regAlumno.idGrupo;
            this.apellidosNombre = regAlumno.apellidosNombre;
            this.dni = regAlumno.dni;
            if (regAlumno.IsmovilNull())
                this.movil = String.Empty;
            else
                this.movil = regAlumno.movil;
            if (regAlumno.IstelefonoNull())
                this.telefono = String.Empty;
            else
                this.telefono = regAlumno.telefono;
            if (regAlumno.IsemailNull())
                this.email = String.Empty;
            else
                this.email = regAlumno.email;
        }

        #region Propiedades

        public int IdAlumno
        {
            get { return idAlumno; }
            set { idAlumno = value; }
        }
        public int IdGrupo
        {
            get { return idGrupo; }
            set { idGrupo = value; }
        }
        public string ApellidosNombre
        {
            get { return apellidosNombre; }
            set { apellidosNombre = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Movil
        {
            get { return movil; }
            set { movil = value; }
        }
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        #endregion

    }
}
/*
        public Alumno()
        {
            this.idAlumno = -1;
            this.apellidosNombre = String.Empty;
            this.dni = String.Empty;
            this.idGrupo = 0;
            this.movil = String.Empty;
            this.telefono = String.Empty;
            this.email = String.Empty;
        }
*/