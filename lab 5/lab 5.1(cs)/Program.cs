using System;

namespace lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDigitString A = new MyDigitString("1f2253fgggggggg2");
            Console.WriteLine(A.Data());
            Console.WriteLine(A.StrLength());
            Console.WriteLine(A.DeleteSymbol('5'));
        }
    }
}
