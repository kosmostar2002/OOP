#include <iostream>
#include <vector>
#include "Lines.h"


int main()
{
    vector<char> line1 = {'a','b','c','d',' ', '#'};
    vector<char> justOneChar = { '#' };
    Lines S1(line1);
    Lines S2;
    Lines S3(S1);

    Lines S4(justOneChar);

    Lines S5 = S1 + S2;



    cout << "Size of S1 is " << S1.lineLenght() << "\n" << endl;
    cout << "S1: ";
    S1.printLine();

    cout << "S2: ";
    S2.printLine();
    cout << "S3: ";
    S3.printLine();

    vector<char> newLine = S5.getLine();
    cout << "S1 + S2: ";
    for (char elem : newLine) {
        cout << elem;
    }
    cout << "\n" << endl;

    cout << "S3 after minus '#': ";
    S3 = S3 - S4;
    S3.printLine();
}
