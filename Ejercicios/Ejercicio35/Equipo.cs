using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio35
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        //private List<Jugador> jugadores;
        private List<Object> jugadores;
        private string nombre;
        private Equipo()
        {
            this.cantidadDeJugadores = 0;
            //this.jugadores = new List<Jugador>();
            this.jugadores = new List<Object>();
            this.nombre = "";
        }
        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }
        //public static bool operator +(Equipo e, Jugador j)
        //{
        //    bool rta = false;
        //    bool newJugador = true;
        //    if (!(e is null) && e.jugadores.Count < e.cantidadDeJugadores)
        //    {
        //        foreach (Object item in e.jugadores)
        //        {
        //            if (item is Jugador && item == j)
        //            {
        //                newJugador = false;
        //                break;
        //            }
        //        }
        //        if (newJugador)
        //        {
        //            e.jugadores.Add(o);
        //            rta = true;
        //        }
        //    }
        //    return rta;
        //}
        //public static bool operator +(Equipo e, DirectorTecnico dt)
        //{
        //    bool rta = false;
        //    bool newDT = true;
        //    if (!(e is null) && e.jugadores.Count < e.cantidadDeJugadores)
        //    {
        //        foreach (DirectorTecnico item in e.jugadores)
        //        {
        //            if (item == dt)
        //            {
        //                newDT = false;
        //                break;
        //            }
        //        }
        //        if (newDT)
        //        {
        //            e.jugadores.Add(dt);
        //            rta = true;
        //        }
        //    }
        //    return rta;
        //}
        public string Mostrar()
        {
            StringBuilder str = new StringBuilder("EQUIPO: \n-\n");
            foreach (Object o in this.jugadores)
            {

                if (o is Jugador)
                {
                    str.Append("JUGADOR\n");
                }
                if (o is DirectorTecnico)
                {
                    str.Append("DT\n");
                }
                if (o is Persona)
                {
                    int dni = (int)o.GetType().GetProperty("Dni").GetValue(o, null);
                    string nombre = (o.GetType().GetProperty("Nombre").GetValue(o, null)).ToString();

                    str.Append($"* Dni: {dni}\n");
                    str.Append($"* Nombre: {nombre}\n");
                }
                if (o is Jugador)
                {                    
                    int partidosJugados = (int)o.GetType().GetProperty("PartidosJugados").GetValue(o, null);
                    int totalGoles = (int)o.GetType().GetProperty("TotalGoles").GetValue(o, null);
                    float promedioGoles = (float)o.GetType().GetProperty("PromedioGoles").GetValue(o, null);

                    str.Append($"* Partidos Jugados: {partidosJugados}\n");
                    str.Append($"* Total Goles: {totalGoles}\n");
                    str.Append($"* Promedio Goles: {promedioGoles}\n\n");
                    //str.AppendFormat($"{ o.GetType().GetMethod("MostrarDatos", new Type[] {typeof(object)}) }\n");
                }
                if (o is DirectorTecnico)
                {
                    DateTime fechaDeNacimiento = (DateTime)o.GetType().GetProperty("FechaDeNacimiento").GetValue(o, null);
                    str.Append($"* fecha De Nacimiento: {fechaDeNacimiento.ToString("MM/dd/yyyy")}\n\n");
                }
                //str.AppendFormat($"{o.MostrarDatos()}\n");
            }
            return str.ToString();
        }

        public static bool operator +(Equipo e, Object o)
        {
            bool rta = false;
            bool newPersona = true;
            if (!(e is null) && e.jugadores.Count < e.cantidadDeJugadores)
            {
                foreach (Object item in e.jugadores)
                {
                    if (item is Jugador && item == o)
                    {
                        newPersona = false;
                        break;
                    }
                    if (item is DirectorTecnico && item == o)
                    {
                        newPersona = false;
                        break;
                    }
                }
                if (newPersona)
                {
                    e.jugadores.Add(o);
                    rta = true;
                }
            }
            return rta;
        }
    }
}
