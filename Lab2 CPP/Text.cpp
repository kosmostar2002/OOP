#include "Text.h"
using namespace std;

void Text::addToText(vector<char> chars) {
	Line word = Line(chars);
	this->text.push_back(word);
}

void Text::getContent() {

	for (Line element : this->text) {
		element.getContest();
	}
}

void Text::delLine() {
	this->text.pop_back();
}

void Text::clearText() {
	this->text.clear();
}

int Text::getShortestLen() {
	int min = this->text[0].strLenght();
	for (Line element : this->text) {
		int l = element.strLenght();
		if (l < min) min = l;
	}
	return min;
}

float Text::percVoicr() {
	int voice = 0;
	int voiced = 0;
	for (Line element : this->text) {
		voice += element.voiceCount();
		voiced += element.voicedCount();
	}
	float perc = float(voiced) / (float(voice) + float(voiced)) * 100.;
	return perc;
}

void Text::delAllDS() {
	vector<Line> temp;
	for (Line newLine : this->text) {
		newLine.deleteDoubleSpaces();
		temp.push_back(newLine);
	}
	this->text.swap(temp);
}

void Text::delAllSES() {
	for (int index = 0; index < this->text.size(); index++) {
		text[index].delStartEndSpaces();
	}
}