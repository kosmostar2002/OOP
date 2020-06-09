using System;
using System.Security.Cryptography.X509Certificates;

namespace Exception_
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Class1 x = new Class1(1, 4, 5);
                Console.WriteLine(x.getRes());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
