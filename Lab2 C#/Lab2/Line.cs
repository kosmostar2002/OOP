using System;
using System.Linq;

namespace Line_
{
    public class Line
    {
        private char[] _line;
        public Line(char[] letters)
        {
            _line = letters;
        }

        public int lineLenght()
        {
            return _line.Length;
        }
        public int VoicesAmount() 
        {
            char[] vowels = { 'a', 'i', 'o', 'e', 'u', 'y' };
            int voices = 0;
            foreach (var element in _line)
            {
                if (vowels.Contains(element))
                {
                    voices += 1;
                }
            }
            return voices;
        }
        public int VoicedAmount()
        {
            char[] vowels = { 'a', 'i', 'o', 'e', 'u', 'y', ' ' };
            int voiced = 0;
            foreach (var element in _line)
            {
                if (!vowels.Contains(element))
                {
                    voiced += 1;
                }
            }
            return voiced;
        }

        public void GetContest()
        {
            foreach (var element in _line)
            {
                Console.Write(element);
            }
            Console.WriteLine();
        }
        public void RemoveRepeatSpaces()
        {
            char[] newLine = new char[_line.Length];
            int delSpaces = 0;
            for (int index = 0; index < _line.Length-1; index++)
            {
                if (!((_line[index] == ' ') && (_line[index + 1] == ' ')))
                    newLine[index - delSpaces] = _line[index];
                else
                {
                    delSpaces += 1;
                    Array.Resize(ref newLine, newLine.Length - 1);
                }
            }
            if (_line[_line.Length - 1] != ' ')
                newLine[newLine.Length - 1] = _line[_line.Length - 1];
            _line = newLine;
        }

        public void RemoveStartEndSpaces()
        {
            if (_line[0]== ' ')
            {
                _line = _line.Skip(1).ToArray();
            }
            if (_line[_line.Length-1] == ' ')
            {
                Array.Resize(ref _line, _line.Length - 1);
            }

        }
    }
}
