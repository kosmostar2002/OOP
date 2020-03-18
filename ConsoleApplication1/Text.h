#pragma once
#include "Line.h"

using namespace std;
class Text
{
private:
	vector<Line> text;
public:
	void addToText(vector<char> chars);
	void delLine();
	void getContent();
	void clearText();
	int getShortestLen();
	float percVoicr();
	void delAllDS();
	void delAllSES();

};

