using System;
using Line_;

namespace Text_
{
    public class Text
    {
        private Line[] _text = new Line[0];

        public void addToText(char[] chars)
        {
            Array.Resize(ref _text, _text.Length + 1);
            Line word = new Line(chars);
            _text[^1] = word;
        }
        public void delLine()
        {
            Array.Resize(ref _text, _text.Length - 1);
        }
        public void ClearText() 
        {
            _text = new Line[0];
        }
        public int SmallestLength() { 
            int minimum = _text[0].lineLenght();
            foreach (var element in _text) // Check every string
            {
                if (element.lineLenght() < minimum)
                {
                    minimum = element.lineLenght();
                }
            }
            return minimum;
        }

        public float PercVoiced()
        {
            float voices = 0;
            float voiced = 0;
            foreach (var element in _text)
            {
                voices += element.VoicesAmount();
                voiced += element.VoicedAmount();
            }
            float perc = voiced / (voiced + voices) * 100;
            return perc;
        }
        public void GetContent()
        {
            foreach (var element in _text)
            {
                element.GetContest();
            }
            Console.WriteLine();
        }

        public void RemoveDoubleSpaces()
        {
            foreach (var element in _text)
            {
                element.RemoveRepeatSpaces();
            }
        }

        public void RemoveStartEndSpaces()
        {
            foreach (var element in _text)
            {
                element.RemoveStartEndSpaces();
            }
        }   

    }
}
