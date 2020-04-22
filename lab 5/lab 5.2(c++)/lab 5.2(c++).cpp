#include <iostream>
#include "Figures.h"
#include "Trapeze.h"
#include "Circle.h"
using namespace std;

int main()
{
    Figures *trapeze = new Trapeze({2,0}, {3,2}, {5,2}, {6,0});
    cout << trapeze->Square() << endl;

    Figures *circle = new Circle({2,0}, {6,0});
    cout << circle->Square() << endl;
}

