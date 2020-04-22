#pragma once
#include <iostream>
#include "Figures.h"
using namespace std;

class Trapeze : public Figures
{
private: 
    Coord A, B, C, D;
    float square = 0, perim = 0;

    float Length(Coord A, Coord B);
    float Height(Coord A, Coord B, Coord C, Coord D);

public:
    Trapeze(Coord A, Coord B, Coord C, Coord D);
    virtual float Square();
    virtual float Perimeter();
};