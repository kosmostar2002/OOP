using System;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    class Line
    {
        public delegate int getChar(char ch);
        public string line { get; set; }
        public Line(string _line)
        {
            line = _line;
        }
        public static int getFirstChar(string str, char ch)
        {
            for (int i = 0; i < str.Length; i++)
                if (str[i] == ch)
                    return i;                
            return -1;
        }
        public int getFirstChar(char ch)
        {
            for (int i = 0; i < line.Length; i++)
                if (line[i] == ch)
                    return i;
            return -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string line = "Hello World";
            Line l1 = new Line(line);
            Line.getChar getFirst = l1.getFirstChar;
            Console.WriteLine(Line.getFirstChar(line, 'l'));          
            Console.WriteLine(getFirst('l'));

        }
    }
}
