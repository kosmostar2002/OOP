#pragma once


#include <vector>
#include <iostream>

using namespace std;

class Figure
{
protected:
    vector<float> dotX;
    vector<float> dotY;

public:
    Figure(int count, float v[][2]);
    float getLen(int dot1, int dot2);
    void getData();
};