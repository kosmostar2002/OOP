#include "Line.h"

using namespace std;

Line::Line(vector<char> letters) {
	this->line.swap(letters);
}

int Line::strLenght() {
	return this->line.size();
}

void Line::getContest() {

	for (char element : this->line) {
		cout << element;
	}
	cout << '\n';
}

int Line::voiceCount() {
	int count = 0;
	for (char element : this->line) {
		if ((element != 'a') and (element != 'o') and (element != 'u') and (element != 'y') and
			(element != 'i') and (element != 'e') and (element != ' '))  count++;
	}
	return count;
}
int Line::voicedCount() {
	int count = 0;
	for (char element : this->line) {
		if (((element == 'a') or (element == 'o') or (element == 'u') or (element == 'y') or
			(element == 'i') or (element == 'e')) and (element != ' ')) {
			count++;
		}
	}
	return count;
}

void Line::deleteDoubleSpaces() {
	vector<char> newLine;
	for (int index = 0; index < this->line.size(); index++) {
		if (not((this->line[index] == ' ') and (this->line[index + 1] == ' '))) 				
			newLine.push_back(line[index]);
	}
	this->line.swap(newLine);
}

void Line::delStartEndSpaces() {
	if (this->line[0] == ' ')
		this->line.erase(this->line.begin());
	if (this->line[3] == ' ')
		this->line.pop_back();
}
