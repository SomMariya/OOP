#pragma once
#include <iostream>
using namespace std;

struct Coord
{
    float x; float y;
};

 class Figures
{
public:
    virtual float Square() = 0;

    virtual float Perimeter() = 0;
};