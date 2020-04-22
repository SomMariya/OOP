#pragma once
#include <iostream>
#include "MyDigitString.h"
using namespace std;

MyDigitString::MyDigitString(string str):MyString(str)
{
    for (int i = 0; i < StrLength(); i++)
    {
        if (!(this->str[i] >= '0') || !(this->str[i] <= '9'))
        {
            this->str = this->str.erase(i, 1);
            i--;
        }
    }
}

 string MyDigitString::DeleteSymbol(char symbol)
    {
        for (int i = 0; i < StrLength(); i++)
        {
            if (str[i] == symbol)
            {
                str = str.erase(i, 1);
            }
        }
        return str;
    }
 string MyDigitString::Data()
 { 
     return str; 
 }


