#pragma once
#include <iostream>
using namespace std;

class MyString
{
protected:
    string str;

public:
    MyString(string str);
    int StrLength();
};