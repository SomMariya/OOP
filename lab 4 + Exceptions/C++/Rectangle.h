#pragma once
#include <iostream>
using namespace std;

struct Coord
{
    float x; float y;
};

class Rectangle
{
private: Coord A, B, C, D;

public:
    Rectangle();
    Rectangle(Coord A, Coord B, Coord C, Coord D);
    Rectangle(const Rectangle& obj);

    float Length(Coord A, Coord B);
    float Square();
    float Perimeter();
    float get_coord(string coord);
    friend Rectangle operator -(const Rectangle & Q3, const Rectangle & Q2);
    friend Rectangle operator /(const Rectangle & Q2, int x);
};