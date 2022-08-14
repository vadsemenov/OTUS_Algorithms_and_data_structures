using System;
using Tester;

namespace Fibonacci
{
    public class Fibonacci3 :ITask
    {
        public string Run(string[] data)
        {
            return null;
        }

        public double F(int n)
        {
            var fi = (Math.Sqrt(5) + 1) / 2;

            var result = Math.Floor((Math.Pow(fi, n) / Math.Sqrt(5)) + 0.5);

            return result;
        }
    }
}