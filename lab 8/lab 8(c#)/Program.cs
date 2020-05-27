using System;
using Library;

namespace lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Symbol str = new Symbol("abc123");
            str.Symbols();

            Symbol.Delegate1 del = Symbol.Symbols;
            del?.Invoke("abc123");

            //////////////////////////////////////////////////////////////

            My_List Lst = new My_List(new string[] { "1. apple", "2. watermelon" });
            try
            {
                Lst.Cleared += My_List.Handler;

                Lst[2] = "3. pineapple";

                Lst.Delete_Component(0);
                Lst.Delete_Component(1);

            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
