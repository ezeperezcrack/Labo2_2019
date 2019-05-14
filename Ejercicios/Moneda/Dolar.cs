using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
  public class Dolar
  {

    private double cantidad;
    private static float cotizRespectoDolar;

    static Dolar()
    {
      Dolar.cotizRespectoDolar = 1;
    }

    public Dolar(double cantidad)
    {
      this.cantidad = cantidad;
    }

    public Dolar(double cantidad, float cotizacion) : this(cantidad)
    {
      Dolar.cotizRespectoDolar = cotizacion;
    }

    public double GetCantidad() { return this.cantidad; }
    public static float GetCotizacion() { return Dolar.cotizRespectoDolar; }

    public static explicit operator Pesos(Dolar d)
    {
      return new Pesos(d.cantidad * Pesos.GetCotizacion());
    }
    public static explicit operator Euro(Dolar d)
    {
      return new Euro(d.cantidad * Euro.GetCotizacion());
    }
    public static implicit operator Dolar(double d)
    {
      return new Dolar(d);
    }
    /*    public static bool operator ==(Pesos p, Dolar d)
        {

        }*/
  }
}
