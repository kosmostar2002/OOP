// EventC++.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include "string"

using namespace std;

char getFirstChar(string line) {
    return line[0];
}

int main()
{
    string line = "qfwe we ";
    char(*fncPtr)(string) = getFirstChar;
    cout << fncPtr(line) << endl;

}
