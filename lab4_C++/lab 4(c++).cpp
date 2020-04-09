#include <iostream>
#include "Rectangle.h"
using namespace std;

int main()
{
    Rectangle Q1 = Rectangle();
    Rectangle Q2 = Rectangle(-2, -1, -2, 1, 2, 2, 2, -1);
    Rectangle Q3 = Rectangle(Q2);

    cout << "\nRECTANGLE Q1:" << endl;
    cout << "1.(" << Q1.get_coord("Ax") << "," << Q1.get_coord("Ay") << ") 2.(" << Q1.get_coord("Bx") << "," << Q1.get_coord("By") << ")" << endl;
    cout << "3.(" << Q1.get_coord("Cx") << "," << Q1.get_coord("Cy") << ") 4.(" << Q1.get_coord("Dx") << "," << Q1.get_coord("Dy") << ")" << endl;
    cout << "Perimeter = " << Q1.Perimeter() << "(sm)" << "\n" << "Square = " << Q1.Square() << "(sm)^2" << endl;
    cout << "Side a = " << Q1.Length(Q1.get_coord("Bx"), Q1.get_coord("Ax"), Q1.get_coord("By"), Q1.get_coord("Ay")) << "(sm)" << endl;
    cout << "Side b = " << Q1.Length(Q1.get_coord("Cx"), Q1.get_coord("Bx"), Q1.get_coord("Cy"), Q1.get_coord("By")) << "(sm)" << endl;

    cout << "\nRECTANGLE Q2:" << endl;
    cout << "1.(" << Q2.get_coord("Ax") << "," << Q2.get_coord("Ay") << ") 2.(" << Q2.get_coord("Bx") << "," << Q2.get_coord("By") << ")" << endl;
    cout << "3.(" << Q2.get_coord("Cx") << "," << Q2.get_coord("Cy") << ") 4.(" << Q2.get_coord("Dx") << "," << Q2.get_coord("Dy") << ")" << endl;
    cout << "Perimeter = " << Q2.Perimeter() << "(sm)" << "\n" << "Square = " << Q2.Square() << "(sm)^2" << endl;
    cout << "Side a = " << Q2.Length(Q2.get_coord("Bx"), Q2.get_coord("Ax"), Q2.get_coord("By"), Q2.get_coord("Ay")) << "(sm)" << endl;
    cout << "Side b = " << Q2.Length(Q2.get_coord("Cx"), Q2.get_coord("Bx"), Q2.get_coord("Cy"), Q2.get_coord("By")) << "(sm)" << endl;

    cout << "\nRECTANGLE Q3:" << endl;
    cout << "1.(" << Q3.get_coord("Ax") << "," << Q3.get_coord("Ay") << ") 2.(" << Q3.get_coord("Bx") << "," << Q3.get_coord("By") << ")" << endl;
    cout << "3.(" << Q3.get_coord("Cx") << "," << Q3.get_coord("Cy") << ") 4.(" << Q3.get_coord("Dx") << "," << Q3.get_coord("Dy") << ")" << endl;
    cout << "Perimeter = " << Q3.Perimeter() << "(sm)" << "\n" << "Square = " << Q3.Square() << "(sm)^2" << endl;
    cout << "Side a = " << Q3.Length(Q3.get_coord("Bx"), Q3.get_coord("Ax"), Q3.get_coord("By"), Q3.get_coord("Ay")) << "(sm)" << endl;
    cout << "Side b = " << Q3.Length(Q3.get_coord("Cx"), Q3.get_coord("Bx"), Q3.get_coord("Cy"), Q3.get_coord("By")) << "(sm)" << endl;

    Q2 = (Q2 / 2);
    cout << "\nRECTANGLE Q2 / 2:" << endl;
    cout << "1.(" << Q2.get_coord("Ax") << "," << Q2.get_coord("Ay") << ") 2.(" << Q2.get_coord("Bx") << "," << Q2.get_coord("By") << ")" << endl;
    cout << "3.(" << Q2.get_coord("Cx") << "," << Q2.get_coord("Cy") << ") 4.(" << Q2.get_coord("Dx") << "," << Q2.get_coord("Dy") << ")" << endl;
    cout << "Perimeter = " << Q2.Perimeter() << "(sm)" << "\n" << "Square = " << Q2.Square() << "(sm)^2" << endl;
    cout << "Side a = " << Q2.Length(Q2.get_coord("Bx"), Q2.get_coord("Ax"), Q2.get_coord("By"), Q2.get_coord("Ay")) << "(sm)" << endl;
    cout << "Side b = " << Q2.Length(Q2.get_coord("Cx"), Q2.get_coord("Bx"), Q2.get_coord("Cy"), Q2.get_coord("By")) << "(sm)" << endl;

    Q1 = (Q3 - Q2);
    cout << "\nRECTANGLE Q1 = Q3 - Q2:" << endl;
    cout << "1.(" << Q1.get_coord("Ax") << "," << Q1.get_coord("Ay") << ") 2.(" << Q1.get_coord("Bx") << "," << Q1.get_coord("By") << ")" << endl;
    cout << "3.(" << Q1.get_coord("Cx") << "," << Q1.get_coord("Cy") << ") 4.(" << Q1.get_coord("Dx") << "," << Q1.get_coord("Dy") << ")" << endl;
    cout << "Perimeter = " << Q1.Perimeter() << "(sm)" << "\n" << "Square = " << Q1.Square() << "(sm)^2" << endl;
    cout << "Side a = " << Q1.Length(Q1.get_coord("Bx"), Q1.get_coord("Ax"), Q1.get_coord("By"), Q1.get_coord("Ay")) << "(sm)" << endl;
    cout << "Side b = " << Q1.Length(Q1.get_coord("Cx"), Q1.get_coord("Bx"), Q1.get_coord("Cy"), Q1.get_coord("By")) << "(sm)" << endl;
    
}

