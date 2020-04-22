using System;

namespace lab_5
{
    class MyDigitString:MyString
    {
        public MyDigitString(string str):base(str)
        {
            for (int i = 0; i < StrLength(); i++)
            {
                if (!(this.str[i] >= '0') || !(this.str[i] <= '9')) 
                {
                    this.str = this.str.Remove(i, 1);
                    i--;
                }
            }
        }
        public string DeleteSymbol(char symbol)
        {
            for (int i = 0; i < StrLength(); i++)
            {
                if (str[i]==symbol)
                {
                    str = str.Remove(i, 1);
                }
            }
            return str;
        }
        public string Data() => str;
    }
}
