#include <iostream>
#include "MyDigitString.h"
#include "MyString.h"
using namespace std;

int main()
{
	MyDigitString A = MyDigitString("dfdff1dg2s345h");
	cout << A.Data() << endl;
	cout << A.StrLength() << endl;
	cout << A.DeleteSymbol('3') << endl;
}

