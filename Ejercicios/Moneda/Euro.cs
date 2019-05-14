using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Euro
    {

        private double cantidad;
        private static float cotizRespectoDolar;

        static Euro()
        {
            Euro.cotizRespectoDolar = 0.89f;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, float cotizacion) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad() { return this.cantidad; }
        public static float GetCotizacion() { return Euro.cotizRespectoDolar; }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.GetCantidad() * Euro.GetCotizacion());
        }
        public static explicit operator Pesos(Euro e)
        {
            Dolar aux = (Dolar)e;
            //var aux = (Dolar)e;
            return new Pesos(aux.GetCantidad() * Pesos.GetCotizacion());
        }
        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }
        
        public static bool operator ==(Euro e, Dolar d)
        {
            return (((Dolar)e).GetCantidad() == d.GetCantidad());
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            return (((Dolar)e).GetCantidad() == ((Dolar)p).GetCantidad());
        }
        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.GetCantidad() == e2.GetCantidad();
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

    public static Euro operator +(Euro e, Pesos p)
    {
      double resultado;
      resultado = ((Dolar)e).GetCantidad() + ((Dolar)p).GetCantidad();
      return ((Euro)resultado).GetCantidad();
    }

    }
}
