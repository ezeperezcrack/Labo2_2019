using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
  class Estante
  {
    private Producto[] productos;
    private int ubicacionEstante;

    private Estante(int capacidad)
    {
      this.productos = new Producto[capacidad];
    }
    public Estante(int capacidad, int ubicacion) : this(capacidad)
    {
      this.ubicacionEstante = ubicacion;
    }

    public Producto[] Productos { get { return this.productos; } }

    public static string MostrarEstante(Estante e)
    {
      string aux = "";
      foreach(Producto p in e.productos)
      {
        aux = aux + Producto.MostrarProducto(p)+ "\n";
      }
      return aux;
    }
    public static bool operator ==(Estante e, Producto p)
    {
      foreach (Producto x in e.productos)
      {
        if( x == p)
        {
          return true;
        }
      }
      return false;
    }
    public static bool operator !=(Estante e, Producto p)
    {
      return !(e == p);
    }

    public static bool operator +(Estante e, Producto p)
    {

      if (e != p)
      {
        for (int i = 0; i < e.productos.Length; i++)
        {
          if (e.productos[i] is null)
          {
            e.productos[i] = p;
            return true;
          }
        }
      }
      return false;
    }
    public static Estante operator -(Estante e, Producto p)
    {
      for(int i=0; i<0; i++)
      {
        if(e.productos[i] == p)
        {
          e.productos[i] = null;
          break;
        }
      }
      return e;
    }
  }
}
