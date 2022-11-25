using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Fibonacci
{
    class Program
    {
        static Stopwatch sw = new Stopwatch();
        static List<double> data = new List<double>();
        static int n;
        static void Main(string[] args)
        {
            Console.WriteLine("Which fibonacci number would you like to know? ");
            int n = int.Parse(Console.ReadLine());


            sw.Start();
            Console.WriteLine(Fibonacci(n));
            sw.Stop();

            Console.WriteLine("Elapsed={0}", sw.Elapsed);
            Console.ReadLine();
        }

        static double Fibonacci(int pN)
        {
            double fibVal;
            if (pN < data.Count())
            {
                return data[pN];
            }

            // stop condition
            if (pN <= 1)
            {
                if (pN == data.Count())
                {
                    fibVal = pN;
                    data.Add(fibVal);
                }
                return pN;
            }

            // recursion
            fibVal = Fibonacci(pN - 2) + Fibonacci(pN - 1);
            data.Add(fibVal);
            return fibVal;
        }
    }
}
