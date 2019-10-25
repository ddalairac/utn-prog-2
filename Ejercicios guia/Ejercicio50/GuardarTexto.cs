using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio50
{
    public class GuardarTexto<V, T> : IGuardar<V, T>
    {
        public bool Guardar(V obj)
        {
            return true;
        }
        public T Leer()
        {
            string str = "Texto Leído";
            return (T)Convert.ChangeType(str, typeof(T));
        }
    }
}
