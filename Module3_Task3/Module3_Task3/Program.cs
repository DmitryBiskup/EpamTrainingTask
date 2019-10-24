using System;

namespace Fibonachi
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number N of items to display: ");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("A series of Fibonacci numbers: ");
            Console.Write("1 ");
            Console.Write("1 ");

            int number1 = 1;
            int number2 = 1;

            for (int i = 3; i <= n; i++)
            {
                var number3 = number1 + number2;
                Console.Write(number3 + " ");
                number1 = number2;
                number2 = number3;
            }

            Console.ReadKey();
        }
    }
}

