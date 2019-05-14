using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
  class Boligrafo
  {
    const short cantidadTintaMaxima  = 100;
    private ConsoleColor color;
    private short tinta;

    public Boligrafo(short tinta, ConsoleColor color)
    {
      this.color = color;
      this.tinta = tinta;
    }

    public ConsoleColor GetColor { get { return this.color; } }
    public short GetTinta { get { return this.tinta; } }

    private void SetTinta(short agregarQuitar)
    {
      short aux = (short)(this.tinta + agregarQuitar);

      if (this.tinta > 0 && agregarQuitar < 0)
      {
        if(aux < 0)
        {
          this.tinta = 0;
        }
        else
        {
          this.tinta = aux;
        }
      }
      else if(this.tinta < 100 && agregarQuitar > 0)
      {
        if (aux >= cantidadTintaMaxima)
        {
          this.tinta = cantidadTintaMaxima;
        }
        else { this.tinta = aux; }
      }
    }
    public void Recargar()
    {
      this.SetTinta(100);
    }
    public bool Pintar(int gasto, out string dibujo)
    {
      int aux;
      if(this.tinta > 0)
      {
        dibujo = "Pudo pintar \n";
        if(this.tinta <= gasto) { aux = this.tinta; }
        else { aux = gasto; }

        for(int i = 0; i < aux; i++)
        {
          dibujo += "* ";
        }
        this.SetTinta((short)(-1*gasto));
        return true;
      }
      dibujo = "No se puede pintar, no hay tinta disponible";
      return false;
    }

  }
}
