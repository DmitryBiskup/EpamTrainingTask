using System;

namespace Module4_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            IncreaseInNumber(out int firstNumber);
            IncreaseInNumber(out int secondNumber);
            IncreaseInNumber(out int thirdNumber);

            Circle(out double length, out double area);

            int[] array = new int[10];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(0, 50);

            Console.WriteLine(string.Join("|", array));

            MinArray(ref array);
            MaxArray(ref array);
            SumOfArrayElements(ref array);


            Console.ReadKey();
        }

        static void IncreaseInNumber(out int sum)
        {
            const int d = 10;

            Console.WriteLine("Enter number: ");
            sum = int.Parse(Console.ReadLine()) + d;

            Console.WriteLine("Result is: " + sum + "\n");
        }

        private static void Circle(out double length, out double area)
        {
            Console.WriteLine("Length and area is circle: ");

            const double pi = 3.14;

            Console.WriteLine("Enter number d: ");
            double d = double.Parse(Console.ReadLine());

            length = d * pi;
            area = (d * d) * pi;

            Console.WriteLine("Result length circle: " + length);
            Console.WriteLine("Result area circle: " + area + "");
        }

        private static void MinArray(ref int[] array)
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

        static void MaxArray(ref int[] array)
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

        static void SumOfArrayElements(ref int[] array)
        {
            int sum = 0;
            foreach (int value in array)
            {
                sum += value;
            }

            Console.WriteLine("Summ element array: " + sum);
        }
    }
}