using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static int valor;
        static int min;
        static int max;
        static int promedio;

        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 1";
            Console.Write("Ingrese cinco numeros \n");
            for(int i=0;i<5;i++)
            {
                int.TryParse(Console.ReadLine(), out valor);
                if (i == 0)
                {
                    min = valor;
                    max = valor;
                    promedio += valor;
                }
                else if(valor >= max)
                {
                    max = valor;
                    promedio += valor;
                }
                else if(valor < min)
                {
                    min = valor;
                    promedio += valor;
                }
            }
            Console.WriteLine("El valor maximo es: " + max);
            Console.WriteLine("El valor minimo es: " + min);
            Console.WriteLine("El promedio es: " + (promedio / 5));
            Console.ReadLine();


        }
    }
}
