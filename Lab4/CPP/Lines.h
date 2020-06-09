#include <vector>;

using namespace std;

class Lines
{
private:
	vector <char> line;
public:
	Lines();
	Lines(vector<char> & letters);
	Lines(const Lines& lines);
	void printLine();
	vector<char> getLine();
	Lines operator+(const Lines& Line2);
	Lines operator-(const Lines& Line2);

	int lineLenght();
};

