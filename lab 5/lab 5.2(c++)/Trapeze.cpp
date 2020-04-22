#include <iostream>
#include "Trapeze.h"
using namespace std;

Trapeze::Trapeze(Coord A, Coord B, Coord C, Coord D)
{
    this->A = A;     this->C = C;
    this->B = B;     this->D = D;
}
float Trapeze::Length(Coord A, Coord B)
{
    float length = sqrt(pow((B.x - A.x), 2) + pow((B.y - A.y), 2));
    return length;
}
float Trapeze::Height(Coord A, Coord B, Coord C, Coord D)
{
    float a = Length(A, D);
    float b = Length(B, C);
    float c = Length(A, B);
    float d = Length(C, D);
    float heigth = sqrt(pow(c, 2) - (pow(((pow((a - b), 2) + pow(c, 2) - pow(d, 2)) / (2 * (a - b))), 2)));
    return heigth;
}
float Trapeze::Square()
{
    float h = Height(A, B, C, D);
    square = (Length(A, B) + Length(B, C)) / 2 * h;
    return square;
}
float Trapeze::Perimeter()
{
    perim = Length(A, B) + Length(B, C) + Length(C, D) + Length(D, A);
    return perim;
}
     
     
      