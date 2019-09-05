using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
21. Crear tres clases: Fahrenheit, Celsius y Kelvin. Realizar un ejercicio similar al anterior, teniendo encuenta que:
F = C * (9/5) + 32
C = (F-32) * 5/9
F = K * 9/5 – 459.67
K = (F + 459.67) * 5/9
*/

namespace Ejercicio21
{
    class Kelvin
    {
        public int value;
        public Kelvin(int value)
        {
            this.value = value;
        }
        private int ToCelcius()
        {
            double result = this.value - 273.15;
            return (int)result;
        }
        private int ToFahrenheit()
        {
            double result = ToCelcius() * 9 / 5 + 32;
            return (int) result;
        }
        public static explicit operator Fahrenheit(Kelvin c)
        {
            int num = 0;
            if (!(c is null))
            {
                num = c.ToFahrenheit();
            }
            Fahrenheit aux = new Fahrenheit(num);
            return aux;
        }
        public static explicit operator Celsius(Kelvin c)
        {
            int num = 0;
            if (!(c is null))
            {
                num = c.ToCelcius();
            }
            Celsius aux = new Celsius(num);
            return aux;
        }
        public static int operator +(Kelvin c1, Kelvin c2)
        {
            int result = 0;
            if (!(c1 is null) && !(c2 is null))
            {
                result = c1.value + c2.value;
            }
            return result;
        }
        public static int operator -(Kelvin c1, Kelvin c2)
        {
            int result = 0;
            if (!(c1 is null) && !(c2 is null))
            {
                result = c1.value - c2.value;
            }
            return result;
        }
        public static bool operator ==(Kelvin c1, Kelvin c2)
        {
            bool response = false;
            if (!(c1 is null) && !(c2 is null))
            {
                response = c1.value.Equals(c2.value);
            }
            return response;
        }
        public static bool operator !=(Kelvin c1, Kelvin c2)
        {
            return !(c1 == c2);
        }
    }
}
