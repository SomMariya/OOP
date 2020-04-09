#pragma once
#include <iostream>
using namespace std;

class Rectangle
{
private:
    float Ax = 0, Ay = 0, Bx = 0, By = 0, Cx = 0, Cy = 0, Dx = 0, Dy = 0;

public:
    Rectangle();
    Rectangle(float Ax, float Ay, float Bx, float By, float Cx, float Cy, float Dx, float Dy);
    Rectangle(const Rectangle& obj);

    float Length(float Bx, float Ax, float By, float Ay);
    float Square();
    float Perimeter();
    float get_coord(string coord);
    friend Rectangle operator -(const Rectangle & Q3, const Rectangle & Q2);
    friend Rectangle operator /(const Rectangle & Q2, int x);
};