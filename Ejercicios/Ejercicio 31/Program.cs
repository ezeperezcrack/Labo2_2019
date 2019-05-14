using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
  class Program
  {
    static void Main(string[] args)
    {

            Cliente c1 = new Cliente(1, "Cristian");
            Cliente c2 = new Cliente(2, "Adrian");
            Cliente c3 = new Cliente(3, "pepe");

            Negocio n = new Negocio("Pago facil");
            //n.Cliente = c1;
            n.Cliente = c2;
            n.Cliente = c3;
            if(n + c1)
            {
                Console.WriteLine("Agregado");
            }

            Console.WriteLine(n.ClientesPendientes);
            Console.ReadLine();
            n.Atendio();
            n.Atendio();
            n.Atendio();
            n.Cliente = c1;
            Console.WriteLine(n.ClientesPendientes);
            Console.ReadLine();
    }
  }
}
