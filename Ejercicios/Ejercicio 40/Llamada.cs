using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_40
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
        public abstract float CostoLlamada { get; }
        public float Duracion { get { return this.duracion; } }
        public string NroDestino { get { return this.nroDestino; } }
        public string NroOrigen { get { return this.nroOrigen; } }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Destino: " + this.NroDestino);
            sb.AppendLine("Origen: " + this.NroOrigen);
            sb.AppendLine("Duracion: " + this.Duracion);
            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return string.Compare(llamada1.Duracion.ToString(), llamada2.Duracion.ToString());
        }
        public static bool operator ==(Llamada l1, Llamada l2)
        {
            if (l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
    }
}
