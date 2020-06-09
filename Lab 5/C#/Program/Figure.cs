using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Figure
    {
        protected float[,] dots;
            
        public Figure(float[,] _dots)
        {
            dots = _dots;
        }

        public float GetLen(int dot1, int dot2)
        {
            return MathF.Sqrt(MathF.Pow(dots[dot1, 0] - dots[dot2, 0], 2) +
                MathF.Pow(dots[dot1, 1] - dots[dot2, 1], 2));
        }

        public virtual void GetData()
        {
            int l = dots.Length/2;
            int number = 1;
            for (int i = 0; i < l; i++)
                for (int j = i + 1; j < l; j++)
                {
                    Console.WriteLine(number.ToString() + " side = " + GetLen(i, j).ToString());
                    number++;
                }
        }
    }
}
