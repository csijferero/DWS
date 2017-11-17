using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridView_a_Lista
{
    public class Equipo
    {
        //Campos
        string nombre;
        byte puntos;
        byte pg;
        byte pe;
        byte pp;
        byte gf;
        byte gc;

        //Constructor
        public Equipo(string nombre, byte puntos, byte pg, byte pe, byte pp, byte gf, byte gc)
        {
            this.nombre = nombre;
            this.puntos = puntos;
            this.pg = pg;
            this.pe = pe;
            this.pp = pp;
            this.gf = gf;
            this.gc = gc;
        }

        public Equipo(string regEquipo)
        {
            string[] tabCampos = regEquipo.Split(';');
            this.nombre = tabCampos[0];
            this.puntos = Convert.ToByte(tabCampos[1]);
            this.pg = Convert.ToByte(tabCampos[2]);
            this.pe = Convert.ToByte(tabCampos[3]);
            this.pp = Convert.ToByte(tabCampos[4]);
            this.gf = Convert.ToByte(tabCampos[5]);
            this.gc = Convert.ToByte(tabCampos[6]);
        }

        //Propiedades

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public byte Puntos
        {
            set { puntos = value; }
            get { return puntos; }
        }

        public byte Pg
        {
            set { pg = value; }
            get { return pg; }
        }

        public byte Pe
        {
            set { pe = value; }
            get { return pe; }
        }

        public byte Pp
        {
            set { pp = value; }
            get { return pp; }
        }

        public byte Gf
        {
            set { gf = value; }
            get { return gf; }
        }

        public byte Gc
        {
            set { gc = value; }
            get { return gc; }
        }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}{3}{4}{5}{6}",
                Util.CuadraTexto(nombre, 15),
                Util.CuadraTexto(puntos.ToString(), 3),
                Util.CuadraTexto(pg.ToString("00"), 3),
                Util.CuadraTexto(pe.ToString("00"), 3),
                Util.CuadraTexto(pp.ToString("00"), 3),
                Util.CuadraTexto(gf.ToString("00"), 3),
                Util.CuadraTexto(gc.ToString("00"), 3));
        }

    }
}
