﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio39
{
    class SobreSobreescrito: Sobreescrito
    {
        public override string MiPropiedad 
        {
            get{ return base.miAtributo; }
            //set { miAtributo = value; }
        }
         public override string MiMetodo() {
            return this.MiPropiedad;
        }
    }
}
