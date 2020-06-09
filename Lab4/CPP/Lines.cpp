#include "Lines.h"
#include <iostream>
#include <ctime>

Lines::Lines() {
	srand(time(0));
	for (int i = 0; i < 10; i++) {
		this->line.push_back('a' + rand() % 26);
	}
}
Lines::Lines(vector<char> &letters) {
	this->line.swap( letters);
}

Lines::Lines(const Lines &lines)
{
	this->line = lines.line;
}


void Lines::printLine() {
	for (char element : this->line) {
		cout << element;
	}
	cout << '\n';
}

int Lines::lineLenght() {
	return this->line.size();
}

Lines Lines::operator+(const Lines& line2) {
	vector<char> result = this->line;
	result.insert(result.end(), line2.line.begin(), line2.line.end());
	return Lines(result);
}
Lines Lines::operator-(const Lines& line2) {
	vector<char> result;
	for (char elem1 : this->line) {
		if (!(count(line2.line.begin(), line2.line.end(), elem1)))
			result.push_back(elem1);
	}
	return Lines(result);
}
vector<char> Lines::getLine() {
	return this->line;
}

