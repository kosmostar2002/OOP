#include "Triangle.h"
#include "math.h"
#include "Figure.h"



Triangle::Triangle(float v[][2]) : Figure(3, v) {
	if ((getLen(0, 1) + getLen(1, 2) <= getLen(0, 2)) or
		(getLen(0, 2) + getLen(1, 2) <= getLen(0, 1)) or
		(getLen(0, 1) + getLen(0, 2) <= getLen(1, 2))) {
		cout << "Triangle don't exist" << endl;
		exit(1);
	}
			
}

float Triangle::fidnP() {
	float P = getLen(0, 1) + getLen(1, 2) + getLen(0, 2);
	return P;
}


float Triangle::findS() {
	float a = getLen(0, 1);
	float b = getLen(1, 2);
	float c = getLen(2, 0);
	float p = (a + b + c) / 2;
	float S = sqrtf(p * (p - a) * (p - b) * (p - c));
	return S;
}

