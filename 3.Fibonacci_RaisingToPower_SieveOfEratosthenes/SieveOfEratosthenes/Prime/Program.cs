using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var prime = new Prime();
            for (int i = 1; i < 1111; i++)
            {
                if (prime.IsPrime(i))
                    Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}