using System;

namespace lab_4
{
    class Rectangle
    {
        private Coord A, B, C, D;
        public Rectangle(){}
        public Rectangle(Coord A, Coord B, Coord C, Coord D)
        {
            if(Length(A,B) != Length(C, D) && Length(B, C) != Length(A, D) && Length(A, C) != Length(B, D))
            {
                throw new ArgumentException(message: "Coords must match the Rectangle");
            }

            this.A = A; this.C = C;
            this.B = B; this.D = D;
        }
        public Rectangle(Rectangle obj)
        {
            A = obj.A;  C = obj.C; 
            B = obj.B;  D = obj.D;
        }
        private float Length(Coord A, Coord B)
        {
            float length = (float)Math.Sqrt(Math.Pow((B.x - A.x), 2) + Math.Pow((B.y - A.y), 2));
            return length;
        }
        public float Square()
        {
            float a = Length(B, A);
            float b = Length(C, B);
            return (a * b);
        }
        public float Perimeter()
        {
            float a = Length(B, A);
            float b = Length(C, B);
            return ((a+b)*2);
        }

        public float get_coord(string coord)
        {
            return coord == "Ax" ? A.x : coord == "Ay" ? A.y : coord == "Bx" ? B.x : coord == "By" ? B.y :
                   coord == "Cx" ? C.x : coord == "Cy" ? C.y : coord == "Dx" ? D.x : D.y;
        }

        public static Rectangle operator -(Rectangle Q3, Rectangle Q2)
        {
            Rectangle Q1_1 = new Rectangle();

            Q1_1.A.x = Q3.A.x - Q2.A.x;    Q1_1.B.x = Q3.B.x - Q2.B.x;
            Q1_1.A.y = Q3.A.y - Q2.A.y;    Q1_1.B.y = Q3.B.y - Q2.B.y;
            Q1_1.C.x = Q3.C.x - Q2.C.x;    Q1_1.D.x = Q3.D.x - Q2.D.x;
            Q1_1.C.y = Q3.C.y - Q2.C.y;    Q1_1.D.y = Q3.D.y - Q2.D.y;

            return Q1_1;
        }
        public static Rectangle operator /(Rectangle Q2, int x)
        {
            Rectangle Q2_2 = new Rectangle();

            if (x == 0)
            {
                throw new DivideByZeroException(message: "variable mustn`t be zero");
            }
            Q2_2.A.x = Q2.A.x / x; Q2_2.B.x = Q2.B.x / x;
            Q2_2.A.y = Q2.A.y / x; Q2_2.B.y = Q2.B.y / x;
            Q2_2.C.x = Q2.C.x / x; Q2_2.D.x = Q2.D.x / x;
            Q2_2.C.y = Q2.C.y / x; Q2_2.D.y = Q2.D.y / x;
            return Q2_2;
        }
    }
}
