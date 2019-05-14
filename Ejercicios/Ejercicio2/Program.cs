using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static int num;
        static double cuadrado = 2;
        static double cubo = 3;
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 2";
            Console.WriteLine("Ingrese numero a elevar: ");
            while(int.TryParse(Console.ReadLine(), out num) == false || num == 0)
            {

                Console.WriteLine("ERROR. ¡Reingresar numero!");
            }
            cuadrado = Math.Pow(num, cuadrado);
            cubo = Math.Pow(num, cubo);
            Console.WriteLine("Cuadrado: " + cuadrado + "\nCubo: " + cubo);

            Console.ReadLine();
        }
    }
}
