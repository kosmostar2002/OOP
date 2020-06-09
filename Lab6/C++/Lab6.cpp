#include <iostream>
#include "Class1.cpp"

using namespace std;
int main()
{
    try {
        Class1 x(1, 4, 5);
        cout << x.getRes << endl;
    }
    catch (runtime_error e) {
        e.what();
    }
}
