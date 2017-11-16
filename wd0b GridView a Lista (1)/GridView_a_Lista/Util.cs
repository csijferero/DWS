using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridView_a_Lista
{
    class Util
    {
        public static string CuadraTexto(string texto, int numCaracteres)
        {
            texto += "                                                                 ";
            return texto.Substring(0, numCaracteres);
        }
    }
}
