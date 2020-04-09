using System;

namespace lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle Q1 = new Rectangle();
            Rectangle Q2 = new Rectangle(-2,-1,-2,1,2,2,2,-1);
            Rectangle Q3 = new Rectangle(Q2);
            


            Console.WriteLine("\nRECTANGLE Q1:");
            Console.WriteLine("1.(" + Q1.get_coord("Ax") + "," + Q1.get_coord("Ay") + ") 2.(" + Q1.get_coord("Bx") + "," + Q1.get_coord("By") + ")");
            Console.WriteLine("3.(" + Q1.get_coord("Cx") + "," + Q1.get_coord("Cy") + ") 4.(" + Q1.get_coord("Dx") + "," + Q1.get_coord("Dy") + ")");
            Console.WriteLine("Perimeter = " + Q1.Perimeter() + "(sm)" + "\n" + "Square = " + Q1.Square() + "(sm)^2");
            Console.WriteLine("Side a = " + Q1.Length(Q1.get_coord("Bx"), Q1.get_coord("Ax"), Q1.get_coord("By"), Q1.get_coord("Ay")) + "(sm)");
            Console.WriteLine("Side b = " + Q1.Length(Q1.get_coord("Cx"), Q1.get_coord("Bx"), Q1.get_coord("Cy"), Q1.get_coord("By")) + "(sm)");

            Console.WriteLine("\nRECTANGLE Q2:");
            Console.WriteLine("1.(" + Q2.get_coord("Ax") + "," + Q2.get_coord("Ay") + ") 2.(" + Q2.get_coord("Bx") + "," + Q2.get_coord("By") + ")");
            Console.WriteLine("3.(" + Q2.get_coord("Cx") + "," + Q2.get_coord("Cy") + ") 4.(" + Q2.get_coord("Dx") + "," + Q2.get_coord("Dy") + ")");
            Console.WriteLine("Perimeter = " + Q2.Perimeter() + "(sm)" + "\n" + "Square = " + Q2.Square() + "(sm)^2");
            Console.WriteLine("Side a = " + Q2.Length(Q2.get_coord("Bx"), Q2.get_coord("Ax"), Q2.get_coord("By"), Q2.get_coord("Ay")) + "(sm)");
            Console.WriteLine("Side b = " + Q2.Length(Q2.get_coord("Cx"), Q2.get_coord("Bx"), Q2.get_coord("Cy"), Q2.get_coord("By")) + "(sm)");

            Console.WriteLine("\nRECTANGLE Q3:");
            Console.WriteLine("1.(" + Q3.get_coord("Ax") + "," + Q3.get_coord("Ay") + ") 2.(" + Q3.get_coord("Bx") + "," + Q3.get_coord("By") + ")");
            Console.WriteLine("3.(" + Q3.get_coord("Cx") + "," + Q3.get_coord("Cy") + ") 4.(" + Q3.get_coord("Dx") + "," + Q3.get_coord("Dy") + ")");
            Console.WriteLine("Perimeter = " + Q3.Perimeter() + "(sm)" + "\n" + "Square = " + Q3.Square() + "(sm)^2");
            Console.WriteLine("Side a = " + Q3.Length(Q3.get_coord("Bx"), Q3.get_coord("Ax"), Q3.get_coord("By"), Q3.get_coord("Ay")) + "(sm)");
            Console.WriteLine("Side b = " + Q3.Length(Q3.get_coord("Cx"), Q3.get_coord("Bx"), Q3.get_coord("Cy"), Q3.get_coord("By")) + "(sm)");

            Q2 = Q2 / 2;
            Console.WriteLine("\nRECTANGLE Q2 / 2:");
            Console.WriteLine("1.(" + Q2.get_coord("Ax") + "," + Q2.get_coord("Ay") + ") 2.(" + Q2.get_coord("Bx") + "," + Q2.get_coord("By") + ")");
            Console.WriteLine("3.(" + Q2.get_coord("Cx") + "," + Q2.get_coord("Cy") + ") 4.(" + Q2.get_coord("Dx") + "," + Q2.get_coord("Dy") + ")");
            Console.WriteLine("Perimeter = " + Q2.Perimeter() + "(sm)" + "\n" + "Square = " + Q2.Square() + "(sm)^2");
            Console.WriteLine("Side a = " + Q2.Length(Q2.get_coord("Bx"), Q2.get_coord("Ax"), Q2.get_coord("By"), Q2.get_coord("Ay")) + "(sm)");
            Console.WriteLine("Side b = " + Q2.Length(Q2.get_coord("Cx"), Q2.get_coord("Bx"), Q2.get_coord("Cy"), Q2.get_coord("By")) + "(sm)");

            Q1 = (Q3 - Q2);
            Console.WriteLine("\nRECTANGLE Q1 = Q3 - Q2:");
            Console.WriteLine("1.(" + Q1.get_coord("Ax") + "," + Q1.get_coord("Ay") + ") 2.(" + Q1.get_coord("Bx") + "," + Q1.get_coord("By") + ")");
            Console.WriteLine("3.(" + Q1.get_coord("Cx") + "," + Q1.get_coord("Cy") + ") 4.(" + Q1.get_coord("Dx") + "," + Q1.get_coord("Dy") + ")");
            Console.WriteLine("Perimeter = " + Q1.Perimeter() + "(sm)" + "\n" + "Square = " + Q1.Square() + "(sm)^2");
            Console.WriteLine("Side a = " + Q1.Length(Q1.get_coord("Bx"), Q1.get_coord("Ax"), Q1.get_coord("By"), Q1.get_coord("Ay")) + "(sm)");
            Console.WriteLine("Side b = " + Q1.Length(Q1.get_coord("Cx"), Q1.get_coord("Bx"), Q1.get_coord("Cy"), Q1.get_coord("By")) + "(sm)");
        }
    }
}
