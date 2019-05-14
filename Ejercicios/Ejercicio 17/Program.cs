using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Program
    {

        static void Main(string[] args)
        {
            Boligrafo bo1 = new Boligrafo(0, ConsoleColor.Blue);
            Boligrafo bo2 = new Boligrafo(50, ConsoleColor.Red);

            string aux;
            if (bo1.Pintar(100, out aux))
            {
                Console.ForegroundColor = bo1.GetColor;
                Console.WriteLine(aux);
                Console.WriteLine(bo1.GetTinta.ToString());
                bo1.Recargar();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(aux);
                Console.ReadLine();
            }
        }
    }
}
