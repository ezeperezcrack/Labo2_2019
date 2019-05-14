using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a1 = new Alumno("pepe", "perez", 1);
            Alumno a2 = new Alumno("tito", "fon", 2);
            Alumno a3 = new Alumno("cristian", "pio", 3);

            a1.Estudiar(1, 1);
            a1.CalcularFinal();
        //Alumno.colegio = "UTN"; siempre va a reemplazar al valor que declare en la clase
            Console.WriteLine(a1.Mostrar());
            a2.Estudiar(5, 7);
            a2.CalcularFinal();
            Console.WriteLine(a2.Mostrar());
            a3.Estudiar(4, 4);
            a3.CalcularFinal();
            Console.WriteLine(a3.Mostrar());
            Console.ReadLine();


        }
    }
}
