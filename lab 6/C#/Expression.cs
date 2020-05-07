using System;

namespace lab_6
{
    class Expression
    {
        public float a { set; get; }
        public float b { set; get; }
        public float c { set; get; }
        public Expression(){}
        public Expression(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public float Calculate()
        {
            if (c == 0)
            {
                throw new DivideByZeroException(message:"Variable (c) cannot be zero");
            }
            if (b < 2)
            {
                throw new ArithmeticException(message:"Variable (b) must be bigger than one");
            }
            if ((a * 2 + b / c) == 0)
            {
                throw new DivideByZeroException(message:"Denomination cannot be zero");
            }

            return (float)(8 * Math.Log10(b - 1) - c) / (a * 2 + b / c);
        }
    }
}
