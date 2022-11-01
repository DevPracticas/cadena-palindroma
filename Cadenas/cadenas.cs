using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadenas
{
    public class cadenas
    {
        string cadena1, cadena2;

        public cadenas(string cadena1, string cadena2)
        {
            this.cadena1 = cadena1;
            this.cadena2 = cadena2;
        }
        public string getConcatenada()
        {
            return cadena1 + cadena2;
        }
        public int getLongitud()
        {
            return getConcatenada().Length;
        }

        public string verificarPalindromo()
        {
            int longitud = getLongitud();
            string cadena = getConcatenada();
            int contador = 0;

            for (int i = 0; i < longitud/2; i++)
                for (int j = longitud - 1; j >= longitud/2; j--)
                   if (cadena[i] == cadena[j])
                       contador++;

            if (contador == longitud/2)
                return "Es palíndromo";
            else
                return "No es palíndromo";
        }
    }
}
