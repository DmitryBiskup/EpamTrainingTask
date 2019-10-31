using System;

namespace Module4_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(0, 50);

            Console.WriteLine(string.Join("|", array));

            MinArray(array);
            MaxArray(array);
            SumOfArrayElements(array);
            ElementDifferenceCalculation(array);
            ArrayChange(array);

            Console.ReadKey();


        }

        static void MinArray(int[] array)
        {
            int minElement = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (minElement > array[i])
                {
                    minElement = array[i];
                }
            }

            Console.WriteLine("Minimum array number: " + minElement);
        }

        static void MaxArray(int[] array)
        {
            int maxElement = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (maxElement < array[i])
                {
                    maxElement = array[i];
                }
            }

            Console.WriteLine("Maximum number of array: " + maxElement);
        }

        static void SumOfArrayElements(int[] array)
        {
            int sum = 0;
            foreach (int value in array)
            {
                sum += value;
            }

            Console.WriteLine("Summ element array: " + sum);
        }

        static void ElementDifferenceCalculation(int[] array)
        {
            int minElement = array[0];
            int maxElement = array[0];

            foreach (int element in array)
            {
                if (element < minElement)
                {
                    minElement = element;
                }
                else if (maxElement < element)
                {
                    maxElement = element;
                }
            }
            int result = maxElement - minElement;
            Console.WriteLine("Element Difference Calculation: " + result);
        }

        static void ArrayChange(int[] array)
        {
            int min = array[0];
            int max = array[0];

            foreach (int element in array)
            {
                if (element < min)
                {
                    min = element;
                }
                else if (max < element)
                {
                    max = element;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    array[i] += max;
                }
                else
                {
                    array[i] -= min;
                }
            }

            Console.WriteLine("Array change: ");
            Console.WriteLine(string.Join("|", array));
        }
    }
}
