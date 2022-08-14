using Tester;

namespace Prime
{
    public class Prime:ITask
    {
        public string Run(string[] data)
        {
            return null;
        }

        public bool IsPrime(int n)
        {
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                if(count>2)
                    return false;

                if(n%i == 0) count++;
            }

            return count == 2;
        }
    }
}