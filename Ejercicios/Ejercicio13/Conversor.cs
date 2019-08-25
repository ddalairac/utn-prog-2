using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos): 
 * string DecimalBinario(double). Convierte un número de entero a binario. 
 * double BinarioDecimal(string). Convierte un número binario a entero.
 * */
namespace Ejercicio13
{
    public static class Conversor
    {
        public static string DecimalBinario(double InDecimal)
        {
            String cadena = "";
            if (InDecimal > 0)
            {
                while (InDecimal > 0)
                {   // Si no hay resto es 0
                    if (InDecimal % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }// Si  hay resto es 1
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    InDecimal = (int)(InDecimal / 2);
                }
            }
            else
            {
                    // Si es 0 no hay nada que convertir 0
                    cadena = "0";
                
            }
            return cadena;
        }
        public static double BinarioDecimal(string inBinario)
        {
            char[] charArray = inBinario.ToCharArray();
            // Invertido, los valores van incrementandose de derecha a izquierda: 16-8-4-2-1
            Array.Reverse(charArray);
            int sum = 0;

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == '1')
                {
                    // Potencia de 2, según la posición
                    sum += (int)Math.Pow(2, i);
                }
            }
            return sum;
        }
    }
}
