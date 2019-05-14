using System;
using System.Collections.Generic;
using System.Text;


namespace Entidades
{
    public class Jugador:Persona
    {

        private float altura;
        private float peso;
        private Posicion posicion;

        public float Altura { get { return this.altura; } }
        public float Peso { get { return this.peso; } }
        public Posicion Posicion { get { return this.posicion; } }

        public Jugador(string nombre, string apellido, int edad, int dni,float peso, float altura, Posicion posicion)
            :base(nombre,apellido, edad, dni)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Posicion: " + this.Posicion.ToString());
            sb.AppendLine("Peso: " + this.Peso.ToString());
            sb.AppendLine("Altura: " + this.Altura.ToString());
            return sb.ToString();
            
        }
        public bool ValidarEstadoFisico()
        {
            float imc = this.Peso / (float)Math.Pow(this.Altura, 2);
            if(imc >= 18.5 && imc <= 25)
            {
                return true;
            }
            return false;
        }
        public override bool ValidarAptitud()
        {
            if (this.Edad <= 40 && this.ValidarEstadoFisico())
            {
                return true;
            }
            return false;
        }
    }
}
