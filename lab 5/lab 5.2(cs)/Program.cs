using System;

namespace lab_5._2_cs_
{
    struct Coord { public float x; public float y; }
    class Program
    {
        static void Main(string[] args)
        {
            Coord c1, c2, c3, c4;
            c1.x = 2; c2.x = 3; c3.x = 5; c4.x = 6;
            c1.y = 0; c2.y = 2; c3.y = 2; c4.y = 0;

            Figures trapeze = new Trapeze(c1, c2, c3, c4);
            Console.WriteLine(trapeze.Square());

            Coord c5, c6;
            c5.x = 2; c6.x = 6; 
            c5.y = 0; c6.y = 0;

            Figures circle = new Circle(c5, c6);
            Console.WriteLine(circle.Square());
        }
    }
}
