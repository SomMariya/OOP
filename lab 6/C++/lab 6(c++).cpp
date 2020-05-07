#include <iostream>
#include "Expression.h"
#include <stdexcept>
using namespace std;

int main()
{
    const int n = 2;
    Expression arr [n];

    arr[0] = Expression(0, 0, 0);
    arr[1] = Expression(3, 2, 1);
          
    try
    {
        for (int i = 0; i < n; i++)
        {
            arr[i].Calculate();
        }

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

            






















/*Expression a;
    a.SetA = 1;
    a.SetB = 0;
    a.SetC = 2;*/