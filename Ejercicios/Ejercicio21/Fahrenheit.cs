using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    public class Fahrenheit
    {
        public int value;
        public Fahrenheit(int value)
        {
            this.value = value;
        }
        public int ToCelcius()
        {
            double result = (this.value - 32) * 5 / 9;
            return (int)result;
        }
        public int ToKelvin()
        {
            double result = (this.value -32)*5 / 9 + 273.15;
            return (int)result;
        }
        public static explicit operator Kelvin(Fahrenheit c)
        {
            int num = 0;
            if (!(c is null))
            {
                num = c.ToKelvin();
            }
            Kelvin aux = new Kelvin(num);
            return aux;
        }
        public static explicit operator Celsius(Fahrenheit c)
        {
            int num = 0;
            if (!(c is null))
            {
                num = c.ToCelcius();
            }
            Celsius aux = new Celsius(num);
            return aux;
        }
        public static int operator +(Fahrenheit c1, Fahrenheit c2)
        {
            int result = 0;
            if (!(c1 is null) && !(c2 is null))
            {
                result = c1.value + c2.value;
            }
            return result;
        }
        public static int operator -(Fahrenheit c1, Fahrenheit c2)
        {
            int result = 0;
            if (!(c1 is null) && !(c2 is null))
            {
                result = c1.value - c2.value;
            }
            return result;
        }
        public static bool operator ==(Fahrenheit c1, Fahrenheit c2)
        {
            bool response = false;
            if (!(c1 is null) && !(c2 is null))
            {
                response = c1.value.Equals(c2.value);
            }
            return response;
        }
        public static bool operator !=(Fahrenheit c1, Fahrenheit c2)
        {
            return !(c1 == c2);
        }
    }
}
