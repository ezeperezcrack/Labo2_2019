using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Equipo
    {
        const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        public DirectorTecnico DirectorTecnico { set { if (value.ValidarAptitud()) { this.directorTecnico = value; } } }
        public string Nombre { get { return this.nombre; } }

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(string nombre)
            : this()
        {
            this.nombre = nombre;
        }

        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(e.Nombre);
            if(e.directorTecnico is null)
            {
                sb.AppendLine("Sin DT asignado");
            }
            else
            {
                sb.AppendLine("DT: " + e.directorTecnico.Mostrar());
            }
            foreach(Jugador j in e.jugadores)
            {
                sb.AppendLine(j.Mostrar());
            }
            return sb.ToString();
        }
        public static bool operator ==(Equipo e, Jugador j)
        {
            if(j != null)
            {
                foreach(Jugador jugador in e.jugadores)
                {
                    if(jugador == j)
                    {
                        return true;
                    }
                }
            }
            return false;
        }   
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }
        public static Equipo operator +(Equipo e, Jugador j)
        {
            if(e != j && e.jugadores.Count < cantidadMaximaJugadores && j.ValidarAptitud())
            {
                e.jugadores.Add(j);
            }
            return e;
        }
        public static bool ValidarEquipo(Equipo e)
        {
            if(e.directorTecnico != null && e.jugadores.Count == 6 && e.CantidadArquerosOK() && e.PosicionesOK())
            {
                return true;
            }
            return false;

        }
        private bool CantidadArquerosOK()
        {
            int i = 0;
            foreach(Jugador j in this.jugadores)
            {
                if(j.Posicion == Posicion.Arquero)
                {
                    i++;
                }
            }
            if(i > 1 || i == 0)
            {
                return false;
            }
            return true;
        }
        private bool PosicionesOK()
        {
            bool arquero = false;
            bool central = false;
            bool defensor = false;
            bool delantero = false;
            foreach(Jugador j in this.jugadores)
            {
                switch (j.Posicion)
                {
                    case Posicion.Arquero:
                        arquero = true;
                        break;
                    case Posicion.Central:
                        central = true;
                        break;
                    case Posicion.Defensor:
                        defensor = true;
                        break;
                    case Posicion.Delantero:
                        delantero = true;
                        break;
                }
                if(arquero == true && defensor == true && central == true && delantero == true)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
