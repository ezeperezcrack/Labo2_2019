using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37
{
    class Local:Llamada
    {
        protected float costo;

        public float CostoLlamada { get { return this.CalcularCosto(); } }

        public Local(Llamada llamada, float costo):this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo){}

        public Local(string origen, float duracion, string destino, float costo):base(duracion,destino,origen)
        {
            this.costo = costo;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Costo: " + this.CostoLlamada.ToString());
            return sb.ToString();
        }

        private float CalcularCosto()
        {
            return (this.costo * base.Duracion);
        }

    }
}
