using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    class Celsius
    {
        public int value;
        public Celsius(int value)
        {
            this.value = value;
        }
        private int ToFahrenheit()
        {
            return (this.value * 9 / 5) + 32;
        }
        private int ToKelvin()
        {
            double result = this.value + 273.15;
            return (int)result;
        }
        public static explicit operator Kelvin(Celsius c)
        {
            int num = 0;
            if (!(c is null)) {
                num = c.ToKelvin();
            }
            Kelvin aux = new Kelvin(num);
            return aux;
        }
        public static explicit operator Fahrenheit(Celsius c)
        {
            int num = 0;
            if (!(c is null))
            {
                num = c.ToFahrenheit();
            }
            Fahrenheit aux = new Fahrenheit(num);
            return aux;
        }
        public static int operator +(Celsius c1, Celsius c2)
        {
            int result = 0;
            if (!(c1 is null) && !(c2 is null))
            {
                result = c1.value + c2.value;
            }
            return result;
        }
        public static int operator -(Celsius c1, Celsius c2)
        {
            int result = 0;
            if (!(c1 is null) && !(c2 is null))
            {
                result = c1.value - c2.value;
            }
            return result;
        }
        public static bool operator ==(Celsius c1, Celsius c2)
        {
            bool response = false;
            if (!(c1 is null) && !(c2 is null))
            {
                response = c1.value.Equals(c2.value);
            }
            return response;
        }
        public static bool operator !=(Celsius c1, Celsius c2)
        {
            return !(c1==c2);
        }

    }
}
