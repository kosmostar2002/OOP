#pragma once
#include <vector>
#include <iostream>

using namespace std;

class Line

{
private:
	vector<char> line;
public:
	Line(vector<char> letters);
	int strLenght();
	void getContest();
	int voiceCount();
	int voicedCount();
	void deleteDoubleSpaces();
	void delStartEndSpaces();
};

