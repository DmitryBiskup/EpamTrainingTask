using System;

namespace Module4_Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5];
            Random rand = new Random();
            for (int i = 0; i < myArray.Length; i++)
                myArray[i] = rand.Next(0, 50);

            Console.Write("Array before change: ");
            Console.WriteLine(string.Join("|", myArray));

            IncreaseArray(myArray);

            Console.ReadKey();
        }

        static void IncreaseArray(int[] array)
        {
            for (int f = 0; f < array.Length; f++)
            {
                array[f] += 5;
            }

            Console.Write("Increase array: ");
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
