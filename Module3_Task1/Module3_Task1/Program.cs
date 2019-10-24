using System;

namespace Module3_Task1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number b:");
            int b = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = 1; i <= b; i++)
            {
                result += a;
            }

            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
