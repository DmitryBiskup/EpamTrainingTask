using System;

namespace Module3_Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("array[{0}]=", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 1; i < array.Length; i++)
                if (array[i] > array[i - 1])
                    Console.Write(" " + array[i]);
            Console.ReadKey();
        }
    }
}
