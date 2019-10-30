using System;

namespace Module3_Task4
{
    class Program
    {
        static void Main()
        {
            int b, c, d;

            Console.WriteLine("Enter the number а: ");
            int a = int.Parse(Console.ReadLine());

            b = a % 10;
            c = a / 10;
            d = b * 10 + c;

            Console.WriteLine("Сonverted number: " + d);
            Console.ReadKey();

        }
    }
}
