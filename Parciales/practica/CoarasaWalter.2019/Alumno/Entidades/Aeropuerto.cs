using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public class Aeropuerto<T> where T : IAvion
    {
        private List<T> vuelos;

        public Aeropuerto()
        {
            vuelos = new List<T>();
        }

        public void FinalizarVuelos()
        {
            foreach (T v in vuelos)
            {
                v.Estrellar();
            }
        }
        public static explicit operator string(Aeropuerto<T> a)
        {
            int cant=0;
            foreach (T t in (List<T>)a.vuelos)
            {
                    if(t.Estado == Avion.EstadoVuelo.Volando)
                    {
                        cant++;
                    }
            }
            return $"El aeropuerto cuenta con {cant} vuelos en estado Volando";
        }
        public static int operator +(Aeropuerto<T> a, T vuelo)
        {
            a.vuelos.Add(vuelo);
            return a.vuelos.Count * 50;
        }
    }
}
