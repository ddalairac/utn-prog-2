using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Posee el método estático Operar para realizar las operaciones matemáticas básicas (+-*/). 
    /// </summary>
    public static class Calculadora
    {
        /// <summary>
        ///  Recibe dos instancias de la clase Numero y un string.
        ///  Realiza una de las 4 operaciones matemáticas básicas (+-*/) dependiendo del string ingresado. 
        ///  El valor retornado es el resultado del cálculo.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador">Resultado del cálculo</param>
        /// <returns></returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double response = 0;
            switch (ValidarOperarador(operador))
            {
                case "+":
                    response = num1 + num2;
                    break;
                case "-":
                    response = num1 - num2;
                    break;
                case "*":
                    response = num1 * num2;
                    break;
                case "/":
                    response = num1 / num2;
                    break;
            }
            return response;
        }

        /// <summary>
        /// Recibe un string, valida que su valor sea uno de los caracteres representativo 
        /// de las 4 operaciones matemáticas básicas (+-*/) y lo retorna. 
        /// Caso contrario retorna '+'.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static string ValidarOperarador(string operador)
        {
            if (operador != "-" && operador != "*" && operador != "/")
            {
                operador = "+";
            }
            return operador;
        }
    }
}
