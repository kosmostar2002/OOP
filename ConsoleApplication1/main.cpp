#include <iostream>
#include <vector>
#include <stdio.h>
#include "Text.h"

using namespace std;

int main() {
	Text txt;

	vector<char> txtLine1 = { 'G', 'o', 'o', 'd' , ' ', ' ', 'd', 'a', 'y' ,' ', 't', 'o','d','a','y' };
	vector<char> txtLine2 = { ' ', 'G', 'o', 'o', 'd' , ' ', 'd', 'a', 'y' ,' ', 'n', 'e','x', 't', ' ','d','a', 'y' };
	vector<char> txtLine3 = { 'G', 'o', 'o', 'd' , ' ', 'd', 'a', 'y' ,' ',' ', 'y', 'e','s', 't', 'e','r','d', 'a', 'y' };
	txt.addToText(txtLine1);
	txt.addToText(txtLine2);
	txt.addToText(txtLine3);
	txt.getContent();
	cout << "\nPerent of voices: " <<  txt.percVoicr() << "\n" << endl;
	cout << "Text after deling all double spaces:" << endl;
	txt.delAllDS();
	txt.getContent();

	cout << "\nText after deling all start/end spaces:" << endl;
	txt.delAllSES();
	txt.getContent();
}


