using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división). 
 * Para ello se le debe pedir al usuario que ingrese dos números y la operación que desea realizar
 * (pulsando el caracter +, -, * ó /). 
 * El usuario decidirá cuándo finalizar el programa. 
 * Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
    a. Calcular (público): Recibirá tres parámetros, 
        el primer número, 
        el segundo número 
        y la operación matemática. 
        El método devolverá el resultado de la operación.
    b. Validar (privado): Recibirá como parámetro el segundo número. 
        Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. 
        Este método devolverá TRUE si el número es distinto de CERO.*/
namespace Ejercicio15
{
    public static class Calculadora
    {
        public static double Calcular(double numero1, double numero2, char operacion) {
            double resultado = 0;
            switch (operacion)
            {
                case '+':
                    resultado = numero1 + numero2;
                    break;
                case '-':
                    resultado = numero1 - numero2;
                    break;
                case '*':
                    resultado = numero1 * numero2;
                    break;
                case '/':
                    if (Validar(numero2)) { 
                        resultado = numero1 / numero2;
                    }
                    break;
            }
            return resultado;
        }
        private static bool Validar(double numero2){
            if(numero2 != 0) { 
                return true;
            } else
            {
                return false;
            }
        }
    }
}
