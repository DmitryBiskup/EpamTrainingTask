using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 4;
            int[,] array = new int[size, size];

            Console.WriteLine("Array: ");
            ArrayInSpiral(array);
            ArrayNumbers(array);
            Equation();

            Console.ReadKey();
        }

        static void ArrayInSpiral(int[,] numbers)
        {
            const int dimension = 0;

            int startSpiral = 1;
            int size = numbers.GetUpperBound(dimension) + 1;

            for (int i = size - 1, j = 0; i >= 0; i--, j++)
            {
                for (int k = j; k < i; k++)
                    numbers[j, k] = startSpiral++;
                for (int k = j; k < i; k++)
                    numbers[k, i] = startSpiral++;
                for (int k = i; k > j; k--)
                    numbers[i, k] = startSpiral++;
                for (int k = i; k > j; k--)
                    numbers[k, j] = startSpiral++;
            }
        }


        static void ArrayNumbers(int[,] array)
        {
            const int measuring = 0;

            int rows = array.GetUpperBound(measuring) + 1;
            int columns = array.Length / rows;


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    int currentNumber = array[i, j];
                    Console.Write($"{currentNumber} ");
                }

                Console.WriteLine();
            }
        }

        static void Equation()
        {
            double a = 0, b = 5, x = 2;

            while (Math.Abs(x * x - 5) > 0.01)
            {
                x = (a + b) / 2;
                if ((a * a - 5) * (x * x - 5) < 0)
                {
                    b = x;
                }
                else
                    if ((x * x - 5) == 0)
                    break;
                if ((x * x - 5) * (b * b - 5) < 0)
                {
                    a = x;
                }

            }
            Console.WriteLine("Division result " + x);
        }
    }
}