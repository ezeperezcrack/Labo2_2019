using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_40
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal { get { return this.CalcularGanancia(Llamada.TipoLlamada.Local); } }
        public float GananciasPorProvincial { get { return this.CalcularGanancia(Llamada.TipoLlamada.Provincial); } }
        public float GananciasPorTotal { get { return this.CalcularGanancia(Llamada.TipoLlamada.Todas); } }
        public List<Llamada> Llamadas { get { return this.listaDeLlamadas; } }

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float costo = 0;
            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if (llamada is Local)
                        {
                            costo += llamada.CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (llamada is Provincial)
                        {
                            costo += llamada.CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Todas:
                        {
                            costo += llamada.CostoLlamada;
                        }
                        break;
                }
            }
            return costo;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Llamadas: \n");
            foreach (Llamada a in this.Llamadas)
            {
                if (a is Provincial)
                {
                    sb.AppendLine(((Provincial)a).ToString());
                }
                else
                {
                    sb.AppendLine(((Local)a).ToString());
                }
            }
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.Llamadas.Add(nuevaLlamada);
        }

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            foreach (Llamada l in c.Llamadas)
            {
                if (l == llamada)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if (c != nuevaLlamada)
            {
                c.AgregarLlamada(nuevaLlamada);
            }
            return c;
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
