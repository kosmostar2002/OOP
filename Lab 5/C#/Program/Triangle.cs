using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Triangle : Figure
    {
        public Triangle(float[,] v)
            : base(v)
        {
            if (v.Length/2 != 3)
            {
                Console.WriteLine("Your figure is not triangle");
                Environment.Exit(1);
            }

            if ((GetLen(0, 1) + GetLen(1, 2) <= GetLen(0, 2)) ||
        (GetLen(0, 2) + GetLen(1, 2) <= GetLen(0, 1)) ||
        (GetLen(0, 1) + GetLen(0, 2) <= GetLen(1, 2))) {
                Console.WriteLine("Your Triangle dont exist");
                Environment.Exit(1);
            }
        }

        public float getP()
        {
            return GetLen(0, 1) + GetLen(1, 2) + GetLen(2, 0);
        }

        public float getS()
        {
            float a = GetLen(0, 1);
            float b = GetLen(1, 2);
            float c = GetLen(2, 0);
            float p = (a + b + c) / 2;
            float S = MathF.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }

        public override void GetData()
        {
            int l = dots.Length / 2;
            int number = 1;
            for (int i = 0; i < l; i++)
                for (int j = i + 1; j < l; j++)
                {
                    Console.WriteLine(number.ToString() + " side = " + GetLen(i, j).ToString());
                    number++;
                }
            Console.WriteLine("P = " + getP().ToString());
            Console.WriteLine("S = " + getS().ToString());

        }
    }
}
