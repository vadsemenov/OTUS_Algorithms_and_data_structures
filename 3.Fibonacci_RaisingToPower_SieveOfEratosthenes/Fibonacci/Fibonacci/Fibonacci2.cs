using Tester;

namespace Fibonacci
{
    public class Fibonacci2 : ITask
    {
        public string Run(string[] data)
        {
            return null;
        }
        public long F(int n)
        {
            if(n==1)
                return 0;
            if(n==2)
                return 1;

            long f_1 = 1;
            long f_2 = 0;
            long result = 0;

            for (int i = 3; i <= n; i++)
            {
                result = f_1 + f_2;
                f_2 = f_1;
                f_1 = result;
            }

            return result;
        }
    }
}