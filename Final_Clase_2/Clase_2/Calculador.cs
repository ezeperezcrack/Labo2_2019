using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2
{
  class Calculador
  {
    private int acumulador;

    public Calculador()
    {
      this.acumulador = 0;
    }

    public void Acumular(string bin)
    {
      this.acumulador += Conversor.BinarioEntero(bin);
    }

    public string getResultadoBinario
    {
      get
      {
        return Conversor.EnteroBinario(acumulador);
      }
    }

    public int getResultadoEntero { get { return this.acumulador; } }


  }
}
