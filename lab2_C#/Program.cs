using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] strA = { 'L', 'o', 'n', 'd', 'o', 'n', '1', ' ', 'i', 's', '2', ' ', 't', 'h', 'e', '3', '\n' };
            char[] strB = { 'c', 'a', 'p', 'i', 't', 'a', 'l', '\n' };
            
            MyLibrary1_cs_.MainString str1 = new MyLibrary1_cs_.MainString(strA);
            MyLibrary1_cs_.MainString str2 = new MyLibrary1_cs_.MainString(strB);
            MyLibrary1_cs_.Container text = new MyLibrary1_cs_.Container();

            text.plus(str1);
            text.plus(str2);
            text.largest_str();
            text.pr_z_text();//процент цифр в тексте
            text.col_v_text();//кол-во символов в тексте
            text.delete_str(str1);
            text.clear();//очищение текста

        }
    }
}
