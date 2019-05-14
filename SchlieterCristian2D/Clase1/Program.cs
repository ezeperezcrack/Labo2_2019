using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    class Program
    {
        /*static int miEntero = 5;
        static bool miBool;
        static string miString;
        static double miDouble = 7;*/
        static int numero1;
        static int numero2;
        static float resultado;
        static string operador;

        static void Main(string[] args)
        {
            /*miEntero = (int)miDouble;
            miString = miEntero.ToString();

            miEntero = int.Parse(miString);//siempre y cuando pueda!!! si es una letra rompe
            int.TryParse(miString, out miEntero);//devuelve el valor de la conversion y confirma si se realizo la operacion
            Console.WriteLine(miEntero);
            Console.ReadLine();*/
            Console.Title = "Calculadora";
            Console.Write("Ingrese primer numero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.Write("Indique que operacion quiere realizar: \n 1-Suma \n 2-Resta \n 3-Multiplicacion \n 4-Division \n");
            operador = Console.ReadLine();

            Console.WriteLine("El resultado es: " + Operacion(numero1, numero2, operador));
            Console.ReadLine();
        }
        static float Operacion(int num1, int num2, string operador)
        {
            switch (operador)
            {
                case "1":
                    resultado = num1 + num2;
                    break;
                case "2":
                    resultado = num1 - num2;
                    break;
                case "3":
                    resultado = num1 * num2;
                    break;
                case "4":
                    if (num1 < num2 ){
                        resultado = (float)num1 / num2;
                        break;
                    }
                    else if(num2 == 0)
                    {
                        Console.WriteLine("Operacion invalida");
                        break;
                    }
                    resultado = num1 / num2;
                    break;
                default:
                    Console.WriteLine("El operador ingresado no es valido");
                    break;

            }
            return resultado;
        }
    }
}
