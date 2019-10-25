using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio50
{
    public class Serializar<T, V> : IGuardar<T, V>
    {
        public bool Guardar(T obj)
        {
            return true;
        }
        public V Leer()
        {
            string str = "Objeto Leído";
            return (V)Convert.ChangeType(str, typeof(V));
        }
    }
}
