using System;

namespace lab_5._2_cs_
{
    class Trapeze:Figures
    {
        private Coord A, B, C, D;
        private float square, perim;
        public Trapeze(Coord A, Coord B, Coord C, Coord D)
        {
            this.A = A;     this.C = C;
            this.B = B;     this.D = D; 
        }
        protected float Length(Coord A, Coord B)
        {
            float length = (float)Math.Sqrt(Math.Pow((B.x - A.x), 2) + Math.Pow((B.y - A.y), 2));
            return length;
        }
        protected float Height(Coord A, Coord B, Coord C, Coord D)
        {
            float a = Length(A, D); 
            float b = Length(B, C);
            float c = Length(A, B);
            float d = Length(C, D);
            float heigth = (float)Math.Sqrt(Math.Pow(c, 2)- (Math.Pow(((Math.Pow((a-b), 2) + Math.Pow(c, 2)- Math.Pow(d, 2))/(2*(a-b))),2)));
            return heigth;
        }
        override public float Square()
        {
            float h = Height(A, B, C, D);
            square = (Length(A, B) + Length(B, C)) / 2 * h;
            return square;
        }
        override public float Perimeter()
        {
            perim = Length(A, B) + Length(B, C) + Length(C, D) + Length(D, A);
            return perim;
        }
    }
}
