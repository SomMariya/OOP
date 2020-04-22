#include <iostream>
#define _USE_MATH_DEFINES
#include <math.h>
#include "Circle.h"
using namespace std;

Circle::Circle(Coord R1, Coord R2)
{
    this->R1 = R1;
    this->R2 = R2;
}
float Circle::Perimeter()
{
    perim = (float)(2 * M_PI * Radius());
    return perim;
}
float Circle::Square()
{
    square = (float)(M_PI * (pow(Radius(), 2)));
    return square;
}
float Circle::Radius()
{
    float radius = sqrt(pow((R2.x - R1.x), 2) + pow((R2.y - R1.y), 2));
    return radius;
}
   
    
    