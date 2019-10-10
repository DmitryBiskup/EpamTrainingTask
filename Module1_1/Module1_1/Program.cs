 using System;

namespace Module1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            b = a + b;
            a = b - a;
            b = b - a;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.ReadKey();
        }
    }
}
