#pragma once
#include <iostream>
#include "MyString.h"
using namespace std;

class MyDigitString:public MyString
{
public:
	MyDigitString(string str);

	string DeleteSymbol(char symbol);

	string Data();
};