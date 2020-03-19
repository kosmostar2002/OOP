using System;

namespace OOP
{
    class Program
    {
        static private int Sum(ref int x, ref int y)
        {
            while (y != 0)
            {
                int carry = x & y;
                x = x ^ y;
                y = carry << 1;
            }
            return x;
        }

        static private int Increment(ref int x)
        {
            x = -(~x);
            return x;
        }

        static private int Decrement(ref int x)
        {
            x = ~(-x);
            return x;
        }

        static private bool Comparing(ref int x, ref int y, string operation)
        {
            int A, B;
            if (operation == "==")
            {
                for (int i = sizeof(int) * 8 - 1; i >= 0; i--)
                {
                    A = (x >> i) & 1;
                    B = (y >> i) & 1;
                    if (A != B)
                        return false;
                }
                return true;
            }
            else if (operation == "<")
            {
                for (int i = sizeof(int) * 8 - 1; i >= 0; i--)
                {
                    A = (x >> i) & 1;
                    B = (y >> i) & 1;
                    if (A < B)
                        return true;
                    else if (B < A)
                        return false;
                }
                return true;
            }
            else if (operation == ">")
            {
                for (int i = sizeof(int) * 8 - 1; i >= 0; i--)
                {
                    A = (x >> i) & 1;
                    B = (y >> i) & 1;
                    if (A > B)
                        return true;
                    else if (A < B)
                        return false;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            int a, b = 0;
            Console.Write("Input operation: ");
            string t = Console.ReadLine();
            Console.Write("Input first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            if ((t != "++") && (t != "--"))
            {
                Console.Write("Input second number: ");
                b = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("result: ");
            if (t == "+") Console.Write(Sum(ref a, ref b));
            if (t == "++") Console.Write(Increment(ref a));
            if (t == "--") Console.Write(Decrement(ref a));
            if (t == "<") Console.Write(Comparing(ref a, ref b, "<"));
            if (t == ">") Console.Write(Comparing(ref a, ref b, ">"));
            if (t == "==") Console.Write(Comparing(ref a, ref b, "=="));
        }
    }
}