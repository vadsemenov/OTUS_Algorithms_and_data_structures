using System;
using System.Runtime.InteropServices;
using Tester;

namespace Fibonacci
{
    public class Fibonacci : ITask
    {
        public string Run(string[] data)
        {
            return null;
        }

        public long F(long n)
        {
            if (n <= 1)
                return 1;

            return F(n - 1) + F(n - 2);
        }
    }
}