using System;
using  clas1;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] ls = new bool[] { true, true, false }; 
            ListOfBools b1 = new ListOfBools(ls);
            Console.WriteLine(b1[0]);
            Console.WriteLine(b1.Sum);
            b1[1] = false;
            b1[0] = false;

            Console.WriteLine(b1.Sum);

        }
    }
}
