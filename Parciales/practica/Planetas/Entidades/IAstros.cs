using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    interface IAstros
    {
        Thread HiloOrbita{ get; set; }
        Thread HiloRotacion { get; set; }
        string orbitar();
        string Rotar();
    }
}

