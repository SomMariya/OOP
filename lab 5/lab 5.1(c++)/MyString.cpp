#pragma once
#include <iostream>
#include "MyString.h"
using namespace std;

MyString::MyString(string str)
{
    this->str = str;
}

int MyString::StrLength()
{
    return size(str);
}


    
