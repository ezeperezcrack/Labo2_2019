using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37
{
  class Provincial : Llamada
  {
    protected Franja franjaHoraria;

    public enum Franja
    {
      Franja_1,
      Franja_2,
      Franja_3
    }

    public float CostoLlamada { get { return this.CalcularCosto(); } }

    public Provincial(Franja miFranja, Llamada llamada)
      :this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
    {

    }
    public Provincial(string origen, Franja miFranja, float duracion, string destino)
      :base(duracion, destino, origen)
    {
        this.franjaHoraria = miFranja;
    }

    //public Provincial(Franja miFranja, Llamada llamada)
    //  : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
    //{
    //  this.franjaHoraria = miFranja;
    //}

    //public Provincial(string origen, Franja miFranja, float duracion, string destino)
    //  : this(miFranja, new Llamada(duracion, destino, origen))
    //{

    //}



    public override string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine(base.Mostrar());
      sb.AppendLine("Franja horaria: " + this.franjaHoraria.ToString());
      sb.AppendLine("Costo: " + this.CostoLlamada.ToString());
      return sb.ToString();
    }

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
  }
}
