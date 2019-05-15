using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_41
{
    public class CentralitaException : Exception
    {
    protected string nombreClase;
    protected string nombreMetodo;

    public CentralitaException(string mensaje, string clase, string metodo) : base(mensaje)
    {
      this.nombreClase = clase;
      this.nombreMetodo = metodo;
    }
    public CentralitaException(string mensaje, string clase, string metodo, Exception innerException) : base(mensaje, innerException)
    { }


    public string NombreClase { get { return this.nombreClase; } }
    public string NombreMetodo { get { return this.nombreMetodo; } }


  }
}
