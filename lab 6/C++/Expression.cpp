#include "Expression.h"
#include <math.h>
#include <stdexcept>
using namespace std;

Expression::Expression(){}
Expression::Expression(float a, float b, float c)
{
    this->a = a;
    this->b = b;
    this->c = c;
}

float Expression::Calculate()
{
    if (c == 0)
    {
        throw logic_error("Variable (c) cannot be zero");
    }
    if (b < 2)
    {
        throw invalid_argument("Variable (b) must be bigger than one");
    }
    if ((a * 2 + b / c) == 0)
    {
        throw logic_error("Denomination cannot be zero");
    }

    return (8 * log10(b - 1) - c) / (a * 2 + b / c);
}









































































/*float Expression::GetA() { return a; }
float Expression::GetB() { return b; }
float Expression::GetC() { return c; }

float Expression::SetA(float a) { this->a = a; }
float Expression::SetB(float b) { this->b = b; }
float Expression::SetC(float c) { this->c = c; }*/