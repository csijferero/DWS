
public struct Grupo
{
    private int idGrupo;
    private string nombre;
    private string alias; // <-- Me servirá para reconstruir la celda de nombre de grupo

    //-- El constructor
    public Grupo(int idGrupo, string nombre, string alias)
    {
        this.idGrupo = idGrupo;
        this.nombre = nombre;
        this.alias = alias;
    }

#region-- Las propiedades
    public int IDGrupo
    {
        get { return idGrupo; }
        set { idGrupo = value; }
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Alias
    {
        get { return alias; }
        set { alias = value; }
    }
#endregion
}


