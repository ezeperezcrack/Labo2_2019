using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
  class Producto
  {
    private string codigoDeBarra;
    private string marca;
    private float precio;

    public Producto(string m, string c, float p)
    {
      this.marca = m;
      this.precio = p;
      this.codigoDeBarra = c;
    }
    public string Marca { get { return this.marca; }  }
    public float Precio { get { return this.precio; } }

    public static string MostrarProducto(Producto p)
    {
      return (string)p + " " + p.Marca + " " + p.Precio.ToString();
    }

    public static explicit operator string(Producto p)
    {
      return p.codigoDeBarra.ToString();
    }

    public static bool operator ==(Producto p1, Producto p2)
    {
      /*return (!(p1 is null) && !(p2 is null) && p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra);
       *
       * AMBOS    FUNCIONAN

       */
      if(p1 is null || p2 is null)  { return false; }
      return (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra);

    }
    public static bool operator !=(Producto p1, Producto p2)
    {
      return !(p1 == p2);
    }

    public static bool operator ==(Producto p, string marca)
    {
      return (p.marca == marca);
    }
    public static bool operator !=(Producto p, string marca)
    {
      return !(p == marca);
    }
  }
}
