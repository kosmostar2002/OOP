#include "Figure.h"
#include <math.h>

Figure::Figure(int count, float v[][2]) {

	for (int i = 0; i < count; i++) {
		this->dotX.push_back(v[i][0]);
		this->dotY.push_back(v[i][1]);
	}

}

float Figure::getLen(int dot1, int dot2) {
	return sqrtf(pow(dotX[dot1] - dotX[dot2], 2) + pow(dotY[dot1] - dotY[dot2], 2));
}

void Figure::getData() {
	int l = dotX.size();
	int number = 1;
	for(int i = 0; i < l ; i++)
		for (int j = i+1; j < l; j++) 
			cout << number++ << " side = " << Figure::getLen(i, j) << endl;
}