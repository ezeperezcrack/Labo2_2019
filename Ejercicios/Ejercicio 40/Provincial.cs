using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_40
{
  public class Provincial:Llamada
  {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected Franja franjaHoraria;

        public Provincial(Franja miFranja, Llamada l)
            :this(l.NroOrigen, miFranja, l.Duracion, l.NroDestino){ }
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            :base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public override float CostoLlamada { get {return this.CalcularCosto(); } }

        private float CalcularCosto()
        {
            float costo = 0;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = (base.Duracion * 0.99f);
                    break;
                case Franja.Franja_2:
                    costo = (base.Duracion * 1.25f);
                    break;
                case Franja.Franja_3:
                    costo = (base.Duracion * 0.66f);
                    break;
            }
            return costo;
        }

        public override bool Equals(object obj)
        {
            return (obj is Provincial);
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Franja horaria: " + this.franjaHoraria.ToString());
            sb.AppendLine("Costo de la llamada: " + this.CostoLlamada.ToString());
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
