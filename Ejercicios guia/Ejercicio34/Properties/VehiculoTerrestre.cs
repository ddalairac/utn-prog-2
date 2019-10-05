﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    public class VehiculoTerrestre
    {
        public short cantidadRuedas;
        public short cantidadPuertas;
        public Colores color;
        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }
        public string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine($"cantidadRuedas: {this.cantidadRuedas}");
            str.AppendLine($"cantidadPuertas: {this.cantidadPuertas}");
            str.Append($"color: {this.color}");
            return str.ToString();
        }
    }
}
