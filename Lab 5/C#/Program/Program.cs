using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,] dots = { { 1, 2 }, { 2, 3 }, { 3, 1} };
            Triangle fig = new Triangle( dots);
            fig.GetData();



        }
    }
}
