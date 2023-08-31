using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaInvertirCadena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadenaTexto = "Hola, soy una cadena de texto";

            string cadenaInvertida = "";

            //Forma 1
            for (int i = (cadenaTexto.Length-1); i >= 0; i--)
            {                
                cadenaInvertida += Convert.ToString(cadenaTexto[i]);                
            }

            Console.WriteLine(cadenaInvertida);

            //Forma 2
            char[] chars = cadenaInvertida.ToCharArray();
            Array.Reverse(chars);
            Console.WriteLine(chars);
        }
    }
}
