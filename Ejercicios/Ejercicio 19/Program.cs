using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
  class Program
  {
    static void Main(string[] args)
    {
            Sumador s1 = new Sumador();
            Sumador s2 = new Sumador();
            
            Console.WriteLine(s1.Sumar(30, 35));
            Console.WriteLine(s2.Sumar("HOLA", "COMO ESTAS"));
            Console.WriteLine(s1+s2);

            if (s1 | s2) { Console.WriteLine("TRUE"); } else { Console.WriteLine("FALSE"); }

            Console.WriteLine((int)s2);
            Console.ReadLine();
    }
  }
}
