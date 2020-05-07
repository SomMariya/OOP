using System;

namespace lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression[] arr = new Expression[2];

            arr[0] = new Expression(2, 4, 0);
            arr[1] = new Expression(3, 2, 1);

            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i].Calculate();
                }

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}































/* Expression a = new Expression();
            a.a = 1;
            a.b = 0;
            a.c = 2;*/
