using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace _Line
{
    class Line
    {
        List<char> line = new List<char>();
        public Line()
        {
            Random rand = new Random();
            char[] chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&".ToCharArray();
            for (int i = 0; i < 20; i++)
            {
                int index = rand.Next(chars.Length - 1);
                line.Add(chars[index]);

            }
        }

        public Line(ref List<char> temp)
        {
            line = temp;
        }

        public Line(Line otherLine)
        {
            line = otherLine.line;
        }


        public static Line operator+ (Line one, Line two)
        {
            List<char> result = new List<char>();
            result = one.line;
            foreach (char letter in two.line)
                result.Add(letter);
            return new Line(ref result);
        }

        public static Line operator- (Line one, List<char> someLetters)
        {
            List<char> result = new List<char>();
            foreach (char letter in one.line)
            {
                if (!someLetters.Any(ch => ch == letter))
                    result.Add(letter);
            }
            return new Line(ref result);
        }
        public void printLine()
        {
            foreach (char letter in line)
                Console.Write(letter);
            Console.WriteLine();
        }

        public List<char> getLine() {
            return line;
        }
        public int lenght()
        {
            return line.Count();
        }
    }

    
}
