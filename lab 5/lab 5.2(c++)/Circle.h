#pragma once
#include <iostream>
#include "Figures.h"
using namespace std;

class Circle : public Figures
{
private:
    Coord R1, R2;
    float square = 0, perim = 0;

    float Radius();

public:
    Circle(Coord R1, Coord R2);
    virtual float Perimeter();
    virtual float Square();
};