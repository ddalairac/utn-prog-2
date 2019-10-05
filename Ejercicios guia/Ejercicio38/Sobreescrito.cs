using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio38
{
    public class Sobreescrito
    {
        public override string ToString()
        {
            //Object.Equals(new Object(), new Sobreescrito());
            return "¡Este es mi método ToString sobreescrito!";
        }
        public override bool Equals(object o)
        {
            return (!(o is null) && (o is Sobreescrito))? true : false;
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}
