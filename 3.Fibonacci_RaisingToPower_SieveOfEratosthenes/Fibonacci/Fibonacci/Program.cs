using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var f = new Fibonacci();
            var f2 = new Fibonacci2();
            var f3 = new Fibonacci3();

            Console.WriteLine(f.F(19-2));
            Console.WriteLine(f2.F(19));
            Console.WriteLine(f3.F(19-1));
            Console.ReadKey();
        }
    }
}
