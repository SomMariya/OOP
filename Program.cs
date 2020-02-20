using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 10);
            int b = rnd.Next(0, 10);
            bool res = Compare(a, b);

            int n = rnd.Next(0, 10);
            Incr(ref n);
        }

        static bool Compare(int a, int b)
        {
            bool res;
            if ((a ^ b) == 0) res = true;
            else res = false;
            return res;
        }

        static void Incr(ref int n)
        {
            int n1 = n;
            for (int i = 0; i < (sizeof(int)*8); i++)
            {   
                n = n ^ (1 << i);
                if ((n1 & (1 << i)) == 0) break;
            }

        }
    }
}
