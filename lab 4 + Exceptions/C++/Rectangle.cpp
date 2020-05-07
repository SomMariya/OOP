#pragma once
#include <iostream>
#include "Rectangle.h"
using namespace std;

Rectangle::Rectangle() {}

Rectangle::Rectangle(Coord A, Coord B, Coord C, Coord D)
{
    if (Length(A, B) != Length(C, D) && Length(B, C) != Length(A, D) && Length(A, C) != Length(B, D))
    {
        throw invalid_argument("Coords must match the Rectangle");
    }
    this->A = A; this->C = C;
    this->B = B; this->D = D;
}

Rectangle::Rectangle(const Rectangle& obj)
{
    A = obj.A; C = obj.C; 
    B = obj.B; D = obj.D; 
}

float Rectangle::Length(Coord A, Coord B)
{
    float length = sqrt(pow((B.x - A.x), 2) + pow((B.y - A.y), 2));
    return length;
}

float Rectangle::Square()
{
    float a = Length(B, A);
    float b = Length(C, B);
    return (a * b);
}

float Rectangle::Perimeter()
{
    float a = Length(B, A);
    float b = Length(C, B);
    return ((a + b) * 2);
}

float Rectangle::get_coord(string coord)
{
    return coord == "Ax" ? A.x : coord == "Ay" ? A.y : coord == "Bx" ? B.x : coord == "By" ? B.y :
        coord == "Cx" ? C.x : coord == "Cy" ? C.y : coord == "Dx" ? D.x : D.y;
}

Rectangle operator -(const Rectangle & Q3, const Rectangle & Q2)
{
    Rectangle Q1_1 = Rectangle();

    Q1_1.A.x = Q3.A.x - Q2.A.x;    Q1_1.B.x = Q3.B.x - Q2.B.x;
    Q1_1.A.y = Q3.A.y - Q2.A.y;    Q1_1.B.y = Q3.B.y - Q2.B.y;
    Q1_1.C.x = Q3.C.x - Q2.C.x;    Q1_1.D.x = Q3.D.x - Q2.D.x;
    Q1_1.C.y = Q3.C.y - Q2.C.y;    Q1_1.D.y = Q3.D.y - Q2.D.y;
    return Q1_1;
}

Rectangle operator /(const Rectangle & Q2, int x)
{
    Rectangle Q2_2 = Rectangle();

    if (x == 0){ throw logic_error("variable mustn`t be zero"); }

    Q2_2.A.x = Q2.A.x / x; Q2_2.B.x = Q2.B.x / x;
    Q2_2.A.y = Q2.A.y / x; Q2_2.B.y = Q2.B.y / x;
    Q2_2.C.x = Q2.C.x / x; Q2_2.D.x = Q2.D.x / x;
    Q2_2.C.y = Q2.C.y / x; Q2_2.D.y = Q2.D.y / x;
    return Q2_2;
}