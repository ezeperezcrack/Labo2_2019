using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class ValidarRespuesta
    {
        public static bool ValidaS_N(char c)
        {
            
            if (char.IsLetter(c))
            {
                c = char.ToLower(c);
                if(c == char.Parse("s"))
                {
                    return true;
                }
                else if(c == char.Parse("n"))
                {
                    return false;
                }
            }
            Console.WriteLine("Error, por favor ingrese S o N");
            return false;
        }
    }
}
