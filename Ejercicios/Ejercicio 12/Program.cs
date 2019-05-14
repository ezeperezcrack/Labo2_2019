using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        public static int num, aux;//FALTA TERMINAR//
        public static string rta;
        static void Main(string[] args)
        {
            
            Console.WriteLine("ingrese los numeros a sumar");
            do
            {
                if (int.TryParse(Console.ReadLine(), out aux))
                {
                    num += aux;
                    Console.WriteLine("Quiere seguir ingresando numeros?");
                    if (ValidarRespuesta.ValidaS_N(char.Parse(Console.ReadLine())))
                    {
                        rta = "s";
                    }
                    else
                    {
                        rta = "n";
                    }
                }
                else
                {
                    Console.WriteLine("Error");
                }
            } while (rta == "s");
            Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}
