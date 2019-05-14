using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            if(valor >= min && valor <= max)
            {
                return true;
            }
            Console.WriteLine("El numero ingresado es mayor/menor");
            return false;
        }
    }
}
