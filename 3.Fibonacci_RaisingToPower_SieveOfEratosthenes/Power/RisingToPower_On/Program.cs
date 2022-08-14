using System;
using System.Diagnostics;
using Tester;

namespace RisingToPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var risingPower = new Power();
            var risingPower2 = new Power2();
            var risingPower3 = new Power3();
            //Tester.Tester tester = new Tester.Tester(risingPower,
            //    @"G:\OTUS\Algorithms and data structures\3.Fibonacci_RaisingToPower_SieveOfEratosthenes\Power\TestData\");
            //tester.RunTests();
            Console.WriteLine(risingPower.RisingPower(1.1, 1000));
            Console.WriteLine(risingPower2.RisingPower(1.1, 1000));
            Console.WriteLine(risingPower3.RisingPower(1.1, 1000));

            Console.ReadKey();
        }
    }
}
