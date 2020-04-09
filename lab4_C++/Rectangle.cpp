#pragma once
#include <iostream>
#include "Rectangle.h"
using namespace std;

Rectangle::Rectangle() {}

Rectangle::Rectangle(float Ax, float Ay, float Bx, float By, float Cx, float Cy, float Dx, float Dy)
{
    this->Ax = Ax; this->Ay = Ay;  this->Cx = Cx; this->Cy = Cy;
    this->Bx = Bx; this->By = By;  this->Dx = Dx; this->Dy = Dy;
}

Rectangle::Rectangle(const Rectangle& obj)
{
    Ax = obj.Ax; Ay = obj.Ay;   Cx = obj.Cx; Cy = obj.Cy;
    Bx = obj.Bx; By = obj.By;   Dx = obj.Dx; Dy = obj.Dy;
}

float Rectangle::Length(float Bx, float Ax, float By, float Ay)
{
    float length = sqrt(pow((Bx - Ax), 2) + pow((By - Ay), 2));
    return length;
}

float Rectangle::Square()
{
    float a = Length(Bx, Ax, By, Ay);
    float b = Length(Cx, Bx, Cy, By);
    return (a * b);
}

float Rectangle::Perimeter()
{
    float a = Length(Bx, Ax, By, Ay);
    float b = Length(Cx, Bx, Cy, By);
    return ((a + b) * 2);
}

float Rectangle::get_coord(string coord)
{
    return coord == "Ax" ? Ax : coord == "Ay" ? Ay : coord == "Bx" ? Bx : coord == "By" ? By :
        coord == "Cx" ? Cx : coord == "Cy" ? Cy : coord == "Dx" ? Dx : Dy;
}

Rectangle operator -(const Rectangle & Q3, const Rectangle & Q2)
{
    Rectangle Q1_1 = Rectangle();
    Q1_1.Ax = Q3.Ax - Q2.Ax;    Q1_1.Bx = Q3.Bx - Q2.Bx;
    Q1_1.Ay = Q3.Ay - Q2.Ay;    Q1_1.By = Q3.By - Q2.By;
    Q1_1.Cx = Q3.Cx - Q2.Cx;    Q1_1.Dx = Q3.Dx - Q2.Dx;
    Q1_1.Cy = Q3.Cy - Q2.Cy;    Q1_1.Dy = Q3.Dy - Q2.Dy;
    return Q1_1;
}

Rectangle operator /(const Rectangle & Q2, int x)
{
    Rectangle Q2_2 = Rectangle();
    if (x != 0)
    {
        Q2_2.Ax = Q2.Ax / x;    Q2_2.Bx = Q2.Bx / x;
        Q2_2.Ay = Q2.Ay / x;    Q2_2.By = Q2.By / x;
        Q2_2.Cx = Q2.Cx / x;    Q2_2.Dx = Q2.Dx / x;
        Q2_2.Cy = Q2.Cy / x;    Q2_2.Dy = Q2.Dy / x;
        return Q2_2;
    }
    else { return Q2; }
}