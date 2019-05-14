using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertece3;
        private Punto vertice4;

        int i = 0;
        int j = 0;

        public Rectangulo(Punto v1, Punto v3)
        {
            Math.Abs()
        }

        public float Area { get { return this.CalcularArea(); } }
        public float Perimetro { get { return this.CalcularPerimetro(); } }

        private float CalcularArea()
        {
            if (i == 0)
            {
                this.area = b * h;
                i = 1;
                return this.area;
            }
            else
            {
                return this.area;
            }
        }
        private float CalcularPerimetro()
        {
            if (j == 0)
            {
                this.perimetro = (b + h) * 2;
                j = 1;
                return this.perimetro;
            }
            else
            {
                return this.perimetro;
            }
        }

    }
}
