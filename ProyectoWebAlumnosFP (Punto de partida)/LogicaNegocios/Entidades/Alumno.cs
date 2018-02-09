
    public class Alumno
    {
        int idAlumno;
        string apellidosNombre;
        string dni;
        int idGrupo;
        //string aliasGrupo;
        string movil;
        string telefono;
        string email;

        public Alumno(int idAlumno, string apellidosNombre, string dni, int idGrupo, string movil, string telefono, string email)
        {
            this.idAlumno = idAlumno;
            this.apellidosNombre = apellidosNombre;
            this.dni = dni;
            this.idGrupo = idGrupo;
            this.movil = movil;
            this.telefono = telefono;
            this.email = email;
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

