using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static int valor;
        static int min;
        static int max;
        static float promedio;
        static int flag = 0;
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 11";
            Console.WriteLine("Ingrese diez numeros:");
            for (int i = 0; i < 10; i++)
            {

                //if(int.TryParse(Console.ReadLine(), out valor) == true)
                //{
                
                do
                {
                    if (int.TryParse(Console.ReadLine(), out valor) == false)
                    {
                        Console.WriteLine("error, no valido");
                        flag = 0;
                        continue;
                    }
                    else if( Validacion.Validar(valor,-100, 100) == true)
                    {
                        flag = 1;
                    }
                } while (flag == 0);
                /*int.TryParse(Console.ReadLine(), out valor);
                    while (Validacion.Validar(valor, -100, 100) == false)
                    {
                        Console.WriteLine("Error, numero no valido");
                        int.TryParse(Console.ReadLine(), out valor);
                    }*/
                    if (i == 0)
                    {
                        min = valor;
                        max = valor;
                        promedio += valor;
                    }
                    else if (valor > max)
                    {
                        max = valor;
                        promedio += valor;
                    }
                    else if (valor < min)
                    {
                        min = valor;
                        promedio += valor;
                    }
                //}
            }
            Console.WriteLine("El valor maximo es: " + max);
            Console.WriteLine("El valor minimo es: " + min);
            Console.WriteLine("El promedio es: " + (promedio / 10));
            Console.ReadLine();
        }
    }
}
