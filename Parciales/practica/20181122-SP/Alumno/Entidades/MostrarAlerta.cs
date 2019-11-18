using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void AlertaDel(string mensaje);
    public static class MostrarAlerta
    {
        public static event AlertaDel AlertaEve;
        public static void InvocarEvento(string mensaje)
        {
            AlertaEve.Invoke(mensaje);
        }
    }
}
