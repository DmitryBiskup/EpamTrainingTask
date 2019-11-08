using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation calc = new Calculation();
            calc.Add(3, 5);
            calc.Add(3, 6, 8);
            calc.Add(3.3, 4.8);
            calc.Add("Hello ", "My Mentor");

            GetSum(new int[3] { 3, 2, -3 }, new int[3] { 4, 5, -2 });
            GetSum(new int[3] { 3, 2, 3 }, new int[5] { 4, -5, 2, 6, 1 });
            GetSum(new int[7] { 8, -44, 2, 4, 9, 11, 13 }, new int[2] { 3, 1 });

            Console.ReadKey();
        }

        public static int[] GetSum(int[] firstArray, int[] secondArray)
        {

            int targetLength = firstArray.Length >= secondArray.Length ? firstArray.Length : secondArray.Length;
            int[] resultArray = new int[targetLength];

            if (targetLength == firstArray.Length)
            {
                for (int i = 0; i < resultArray.Length; i++)
                {
                    resultArray[i] = firstArray[i];
                }
                for (int i = 0; i < secondArray.Length; i++)
                {
                    resultArray[i] += secondArray[i];
                }
            }
            else
            {
                for (int i = 0; i < resultArray.Length; i++)
                {
                    resultArray[i] = secondArray[i];
                }
                for (int i = 0; i < firstArray.Length; i++)
                {
                    resultArray[i] += firstArray[i];
                }
            }
            Console.WriteLine(String.Join(" ", resultArray));
            return resultArray;

        }
    }

    class Calculation
    {
        public void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Result is: " + result);
        }

        public void Add(int a, int b, int c)
        {
            int result = a + b + c;
            Console.WriteLine("Result is: " + result);
        }

        public void Add(double a, double b)
        {
            double result = a + b;
            Console.WriteLine("Result is: " + result);
        }

        public void Add(string a, string b)
        {
            string result = a + b;
            Console.WriteLine("Result is: " + result);
        }
    }
}

