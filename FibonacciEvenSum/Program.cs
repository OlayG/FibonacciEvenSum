using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            getFibonacci(11);
            Console.ReadKey();
        }

        private static void getFibonacci(int len)
        {
            Fib_Rec(0, 1, 1, len);
        }

        private static void Fib_Rec(int a, int b, int count, int len)
        {
            if(count <= len)
            {
                if (a % 2 == 0)
                {
                    Console.Write("{0} ", a);
                }
                Fib_Rec(b, a + b, count + 1, len);
            }
        }
    }
}
