﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8
{
    class Symbol
    {
        private string str;

        public delegate int Delegate1(string str);
        public Symbol(string str)
        {
            this.str = str;
        }
        public int Symbols()
        {
            int digits = 0, letters = 0;
            if (str.Length == 0)
                throw new ArgumentException(message: "The string is empty");
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if ((str[i] >= '0') && (str[i] <= '9'))
                        digits++;
                    if ((str[i] >= 'a') && (str[i] <= 'z'))
                        letters++;
                    if ((str[i] >= 'A') && (str[i] <= 'Z'))
                        letters++;
                }
                if (digits == 0 && letters == 0)
                    throw new ArithmeticException("The string has no letters or digits\n");
                if (digits > letters)
                    return 1;
                if (digits < letters)
                    return -1;
                else
                    return 0;
            }
        }
        static public int Symbols(string str)
        {
            int digits = 0, letters = 0;
            if (str.Length == 0)
                throw new ArgumentException(message: "The string is empty");
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if ((str[i] >= '0') && (str[i] <= '9'))
                        digits++;
                    if ((str[i] >= 'a') && (str[i] <= 'z'))
                        letters++;
                    if ((str[i] >= 'A') && (str[i] <= 'Z'))
                        letters++;
                }
                if (digits == 0 && letters == 0)
                    throw new ArithmeticException("The string has no letters or digits\n");
                if (digits > letters)
                    return 1;
                if (digits < letters)
                    return -1;
                else
                    return 0;
            }
        }
    }
}
