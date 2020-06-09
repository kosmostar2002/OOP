#include "math.h"
#include "iostream"
using namespace std;

class Class1
{
private:
    float A;
    float C;
    float D;

    float numerator()
    {
        if (D > 0)
        {
            float res = 2 * C - log(D);
            return res;
        }
        else
        {
            throw new runtime_error("D should be more 0");
        }

    }
    float dominator()
    {
        float res = pow(A, 2) - 1;
        if (res != 0)
        {
            return res;
        }
        else
        {
            throw new runtime_error("Dominator == 0");
        }
    }

public:
    Class1(float a, float c, float d)
    {
        if (abs(A) != 1)
        {
            A = a;
        }
        else
        {
            throw new runtime_error("Dominator == 0");
        }
        C = c;
        if (D > 0)
        {
            D = d;
        }
        else
        {
            throw new runtime_error("D should be more 0");
        }
    }


    float getRes()
    {
        return numerator() / dominator();
    }
};