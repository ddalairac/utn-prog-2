using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Test
    {
        
        private string name = "bla";
        private int num = 1;
        public static implicit operator string(Test p)
        {
            return $"funciona {p.name}";
        }
        public static explicit operator int(Test p)
        {
            return p.num;
        }
    }
}
