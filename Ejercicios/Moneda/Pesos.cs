using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Pesos
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        static Pesos()
        {
            Pesos.cotizRespectoDolar = 0.023f;
        }
        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Pesos(double cantidad, float cotizacion) : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad() { return this.cantidad; }
        public static float GetCotizacion() { return Pesos.cotizRespectoDolar; }

        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.GetCantidad() * Pesos.GetCotizacion());
        }

        public static explicit operator Euro(Pesos p)
        {
            var aux = (Dolar)p;

            return new Euro(aux.GetCantidad() * Euro.GetCotizacion());
        }
        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            return (((Dolar)p).GetCantidad() == d.GetCantidad());
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }
        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return (p1.GetCantidad() == p2.GetCantidad());
        }
        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            return (((Dolar)e).GetCantidad() == ((Dolar)p).GetCantidad());
        }
        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }
        public static Pesos operator +(Pesos p, Dolar d)
        {
            double resultado;
            resultado = ((Dolar)p).GetCantidad() + d.GetCantidad();
            return ((Pesos)resultado).GetCantidad();
        }
        public static Pesos operator -(Pesos p, Dolar d)
        {
            double resultado;
            resultado = ((Dolar)p).GetCantidad() - d.GetCantidad();
            return ((Pesos)resultado).GetCantidad();
        }
        public static Pesos operator +(Pesos p, Euro e)
        {
            double resultado;
            resultado = ((Dolar)p).GetCantidad() + ((Dolar)e).GetCantidad();
            return ((Pesos)resultado).GetCantidad();
        }
        public static Pesos operator -(Pesos p, Euro e)
        {
            double resultado;
            resultado = ((Dolar)p).GetCantidad() - ((Dolar)e).GetCantidad();
            return ((Pesos)resultado).GetCantidad();
        }


    }
}
