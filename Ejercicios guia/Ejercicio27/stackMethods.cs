using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27
{
    class stackMethods
    {

        public static void Print(Stack<int> s)
        {

            Stack<int> stack = s;

            while (stack.Count > 0)
            {

                Console.Write("{0}, ", stack.Peek());
                stack.Pop();
            }

            Console.Write("null \n");
        }

        public static void Sort(Stack<int> stack)
        {

            Stack<int> temp = new Stack<int>();

            while (stack.Count > 0)
            {

                int t = stack.Pop();

                while (temp.Count > 0 && t < temp.Peek())
                {

                    stack.Push(temp.Pop());
                }

                temp.Push(t);
            }

            while (temp.Count > 0)
                stack.Push(temp.Pop());
        }
    }
}
