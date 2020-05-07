using System;

namespace lab_4
{
    struct Coord { public float x; public float y; }
    class Program
    {
        static void Main(string[] args)
        {
            Coord c1, c2, c3, c4;
            c1.x = 0; c2.x = 3; c3.x = 5; c4.x = 6;
            c1.y = 0; c2.y = 2; c3.y = 2; c4.y = 0;

            try
            {
                Rectangle Q1 = new Rectangle();
                Rectangle Q2 = new Rectangle(c1, c2, c3, c4);
                Rectangle Q3 = new Rectangle(Q2);

                Q2 = Q2 / 0;
                Q1 = (Q3 - Q2);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
