using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    class MyString
    {
        protected string str;
        public MyString(string str)
        {
            this.str = str;
        }
        public int StrLength() => str.Length;
    }
}