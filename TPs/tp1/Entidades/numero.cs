using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Posee métodos estáticos para pasar de binario a decimal y viceversa. 
    /// </summary>
    public class Numero
    {
        private double numero;
        /// <summary>
        /// Recibe un double y carga su valor en el atributo número
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Recibe un string, parsea su valor double y lo carga en el atributo número. 
        /// De no ser posible, carga el valor 0 en el mismo atributo.
        /// </summary>
        /// <param name="numero"></param>
        public Numero(string numero)
        {
            if (!double.TryParse(numero, out this.numero))
            {
                this.numero = 0;
            }
        }

        /// <summary>
        /// Si no recibe parámetros carga el valor 0 en el atributo número. 
        /// </summary>
        public Numero() : this(0) { }

        /// <summary>
        /// Recibe un double y carga su valor en el atributo número
        /// </summary>
        /// <param name="numero"></param>
        public void SetNumero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Recibe un string, llama al método ValidarNumero y se lo pasa.
        /// Con su retorno (El retorno será un double) llama a la sobrecarga de este método (SetNumero) que recibe double 
        /// </summary>
        /// <param name="numero"></param>
        public void SetNumero(string numero)
        {
            SetNumero(ValidarNumero(numero));
        }

        /// <summary>
        /// Recibe un string, parsea su valor double y lo retorna. 
        /// De no ser posible, retorna 0.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        private double ValidarNumero(string numero)
        {
            double response;
            if (!double.TryParse(numero, out response))
            {
                response = 0;
            }
            return response;
        }

        /// <summary>
        /// Retorna el valor del atributo número
        /// </summary>
        /// <returns></returns>
        public double GetNumero()
        {
            return this.numero;
        }

        /// <summary>
        /// Recibe 2 instancias de la esta clase y retorna la suma los atributos 'numero' de las mismas
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double operator +(Numero a, Numero b)
        {
            return a.numero + b.numero;
        }

        /// <summary>
        /// Recibe 2 instancias de la esta clase y retorna la resta los atributos 'numero' de las mismas
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double operator -(Numero a, Numero b)
        {
            return a.numero - b.numero;
        }

        /// <summary>
        /// Recibe 2 instancias de la esta clase y retorna la multiplicación los atributos 'numero' de las mismas
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double operator *(Numero a, Numero b)
        {
            return a.numero * b.numero;
        }

        /// <summary>
        /// Recibe 2 instancias de la esta clase y retorna la división los atributos 'numero' de las mismas.
        /// Si el valor del divisor es 0 retorna el mínimo valor de un double
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double operator /(Numero a, Numero b)
        {
            double response = double.MinValue;
            if (b.numero != 0)
            {
                response = a.numero / b.numero;
            }
            return response;
        }

        // BinarioDecimal y DecimalBinario
        /// <summary>
        /// Recibe un double, lo convierte a binario y lo retorna como string
        /// </summary>
        /// <param name="InDecimal"></param>
        /// <returns></returns>
        public static string DecimalBinario(double InDecimal)
        {
            String response = "";
            if (InDecimal < 0)
            {
                InDecimal = InDecimal * -1;
            }

            while (InDecimal > 0)
            {   // Si no hay resto es 0
                if (InDecimal % 2 == 0)
                {
                    response = "0" + response;
                }// Si  hay resto es 1
                else
                {
                    response = "1" + response;
                }
                InDecimal = Math.Truncate(InDecimal / 2);
            }

            return response;
        }

        /// <summary>
        /// Recibe un string, parsea su valor a double, lo convierte a binario y lo retorna como string.
        /// De no ser posible, retorna "Valor inválido"
        /// </summary>
        /// <param name="InDecimalString"></param>
        /// <returns></returns>
        public static string DecimalBinario(string InDecimalString)
        {
            double InDecimal;
            string response = "";
            if (double.TryParse(InDecimalString, out InDecimal))
            {
                response = DecimalBinario(InDecimal);
            }
            else
            {
                response = "Valor inválido";
            }
            if (response == "")
            {
                response = "0";
            }
            return response;
        }

        /// <summary>
        /// Recibe un string esperando que sea un número binario, lo convierte a decimal y lo retorna como string.
        /// De no ser posible, retorna "Valor inválido"
        /// </summary>
        /// <param name="inBinario"></param>
        /// <returns></returns>
        public static string BinarioDecimal(string inBinario)
        {




            char[] charArray = inBinario.ToCharArray();
            Array.Reverse(charArray);

            int toDecimal = 0;
            string response = "";

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == '0' || charArray[i] == '1')
                {
                    if (charArray[i] == '1')
                    {
                        // Potencia de 2, según la posición
                        toDecimal += (int)Math.Pow(2, i);
                        response = toDecimal.ToString();
                    }
                }
                else
                {
                    response = "Valor inválido";
                    break;
                }
            }
            if (response == "")
            {
                response = "0";
            }
            return response;
        }
    }
}
