using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_40
{
  public class Local : Llamada
  {
    protected float costo;

    public Local(Llamada l, float costo) : this(l.NroOrigen, l.Duracion, l.NroDestino, costo)
    {

    }
    public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
    {
      this.costo = costo;
    }

    public override float CostoLlamada { get { return this.CalcularCosto(); } }

    private float CalcularCosto()
    {
      return (this.costo * base.Duracion);
    }

    public override bool Equals(object obj)
    {
      return (obj is Local && this == (Local)obj);
    }

    protected override string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine(base.Mostrar());
      sb.AppendLine("Costo de la llamada: " + this.CostoLlamada);
      return sb.ToString();
    }

    public override string ToString()
    {
      return this.Mostrar();
    }
  }
}
