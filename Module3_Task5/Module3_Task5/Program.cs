using System;

namespace Module3_Task5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число ");
            string digs = Console.ReadLine();
            Console.WriteLine("Введите цифру ");
            string dig = Console.ReadLine();

            var result = String.Join("", digs.Split(dig.ToCharArray()[0]));
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
