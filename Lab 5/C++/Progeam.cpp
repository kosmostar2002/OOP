#include <iostream>
#include "Figure.h"
#include "Triangle.h"
int main()
{
    float Coord[3][2] = { {1, 2}, {2,3}, {3,1} };
    int l = 3;
    Figure fig(3, Coord);
    Triangle tri(Coord);
    cout << "P = " << tri.fidnP() << endl;
    cout << "S = " << tri.findS() << endl;
    tri.getData();

}