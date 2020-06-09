#pragma once


#include "Figure.h"

class Triangle : public Figure
{
public:
	float fidnP();
	float findS();
	Triangle(float v[][2]);

};

#include "Triangle.h"
#include "math.h"
#include "Figure.h"
