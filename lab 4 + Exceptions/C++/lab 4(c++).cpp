#include <iostream>
#include "Rectangle.h"
#include <stdexcept>
using namespace std;

int main()
{
    try
    {
        Rectangle Q1 = Rectangle();
        Rectangle Q2 = Rectangle({ -2, -1 }, { -2, 1 }, { 2, 1 }, { 2, -1 });
        Rectangle Q3 = Rectangle(Q2);

        Q2 = (Q2 / 0);
        Q1 = (Q3 - Q2);
    }
    catch (invalid_argument ex)
    {
        cout << ex.what();
    }
    catch (logic_error ex)
    {
        cout << ex.what();
    }
}

