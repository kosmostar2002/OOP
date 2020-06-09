using System;
using System.Collections.Generic;
using _Line;
namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> line1 = new List<char>("I like c#");
            List<char> someLetter = new List<char>("#");
            Line S1 = new Line();
            Line S2 = new Line(ref line1);
            Line S3 = new Line(S1);
            Console.Write("S1: ");
            S1.printLine();

            Console.Write("S2: ");
            S2.printLine();

            Console.Write("S3: ");
            S3.printLine();

            Console.Write("S4 = S1 + S2: ");
            Line S4 = S1 + S2;
            S4.printLine();

            Console.Write("S5 = S2 - '#': ");
            Line S5 = S2 - someLetter;
            S5.printLine();
            Console.WriteLine("Lenght of S4 is: " + S4.lenght().ToString());


        }
    }
}
