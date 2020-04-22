using System;

namespace lab_5._2_cs_
{
    class Circle:Figures
    {
        private Coord R1, R2;
        private float square, perim;
        public Circle(Coord R1, Coord R2)
        {
            this.R1 = R1;
            this.R2 = R2;
        }
        protected float Radius()
        {
            float radius = (float)Math.Sqrt(Math.Pow((R2.x - R1.x), 2) + Math.Pow((R2.y - R1.y), 2));
            return radius;
        }
        override public float Square()
        {
            square = (float)(Math.PI * (Math.Pow(Radius(), 2)));
            return square;
        }
        override public float Perimeter()
        {
            perim = (float)(2 * Math.PI * Radius());
            return perim;
        }
    }
}
