using System;

namespace Module3_Task2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number N: ");
            int N = int.Parse(Console.ReadLine());
            int i = 1;
            int k = 1;

            while (true)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                    k++;
                }
                if (k > N)
                {
                    break;
                }
                i++;
            }
            Console.ReadKey();

        }
    }
}
