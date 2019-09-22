using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;
        private Equipo() {
            this.cantidadDeJugadores = 0;
            this.jugadores = new List<Jugador>();
            this.nombre = "";
        }
        public Equipo(short cantidad,string nombre):this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }
        public static bool operator +(Equipo e, Jugador j)
        {
            bool rta = false;
            bool newJugador = true;
            if (!(e is null) && e.jugadores.Count < e.cantidadDeJugadores) {
                foreach (Jugador item in e.jugadores){
                    if(item == j)
                    {
                        newJugador = false;
                        break;
                    }
                }
                if (newJugador)
                {
                    e.jugadores.Add(j);
                    rta = true;
                }
            }
            return rta;
        }
    }
}
