using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37
{
    class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal { get {return this.CalcularGanacia(Llamada.TipoLlamada.Local); } }
        public float GananciasPorProvincial { get {return this.CalcularGanacia(Llamada.TipoLlamada.Provincial); } }
        public float GananciasPorTotal { get {return this.CalcularGanacia(Llamada.TipoLlamada.Todas); } }

        public List<Llamada> Llamadas{ get{ return this.listaDeLlamadas; } }

        public Centralita(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        private float CalcularGanacia(Llamada.TipoLlamada tipo)
        {
            float costo = 0;
            foreach(Llamada llamada in this.listaDeLlamadas)
            {
                if(llamada is Local && tipo == Llamada.TipoLlamada.Local)
                {
                    costo += ((Local)llamada).CostoLlamada;
                }
                else if(llamada is Provincial && tipo == Llamada.TipoLlamada.Provincial)
                {
                    costo += ((Provincial)llamada).CostoLlamada;
                }
                else
                {
                    if(llamada is Provincial)
                    {
                        costo += ((Provincial)llamada).CostoLlamada;
                    }
                    else
                    {
                        costo += ((Local)llamada).CostoLlamada;
                    }
                }
            }
            return costo;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Llamadas: \n");
            foreach (Llamada a in this.listaDeLlamadas)
            {
                if (a is Provincial)
                {
                    sb.AppendLine(((Provincial)a).Mostrar());
                }
                else
                {
                    sb.AppendLine(((Local)a).Mostrar());
                }
            }
            return sb.ToString();

        }
        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
