using System;

namespace Module4_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            (int firstNumber, int secondNumber, int thirdNumber) numbersFromUser = GetTupleOfIncreasedNumbers();
            Console.WriteLine($"Your numbers are increased by ten {numbersFromUser}");
            

            (int radius, double circumference, double area) = Circle();

            Console.WriteLine($"Circumference is {circumference} \n" +
                              $"Area of the circle is {area} \n" +
                              $"Radius of the circle is {radius}");
            

            int[] numbers = new int[5];
            RandomArray(numbers);
            (int maxArray, int minArray, int sum) = CalculateArrayValues(numbers);

            ShowArrayNumbers(numbers, "Array is filled with such numbers :");

            Console.WriteLine($"Max array element - {maxArray} \n" +
                              $"Min array element - {minArray} \n" +
                              $"Sum of all array elements - {sum} \n");

            Console.ReadKey();
        }

        private static int GetNumber(string messageToUser)
        {
            bool numberIsValid;
            int number;

            do
            {
                Console.Write($"{messageToUser} ");
                string response = Console.ReadLine();
                numberIsValid = int.TryParse(response, out number);

                if (!numberIsValid)
                {
                    Console.WriteLine("Sorry, you can only enter a number");
                }
            }
            while (!numberIsValid);

            return number;
        }

        private static void RandomArray(int[] array)
        {
            
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(1, 50);
        }

        private static void ShowArrayNumbers(int[] numbers, string message)
        {
            Console.Write(message);

            foreach (int currentNumber in numbers)
            {
                Console.Write($" {currentNumber}");
            }

            Console.WriteLine("\n");
        }

        private static (int firstNumber, int secondNumber, int thirdNumber) GetTupleOfIncreasedNumbers()
        {
            int firstNumber = GetNumber("Enter the first number:");
            int secondNumber = GetNumber("Enter the second number:");
            int thirdNumber = GetNumber("Enter the third number:");

            return (IncreaseInNumber(firstNumber), IncreaseInNumber(secondNumber), IncreaseInNumber(thirdNumber));
        }

        private static int IncreaseInNumber(int target, int increaseCount = 10)
        {
            return target + increaseCount;
        }

        private static (int maxNumber, int minNumber, int sum) CalculateArrayValues(int[] numbers)
        {
            int minNumber = numbers[0];
            int maxNumber = numbers[0];
            int sum = 0;

            foreach (int currentNumber in numbers)
            {
                sum += currentNumber;

                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }
                else if (currentNumber < minNumber)
                {
                    minNumber = currentNumber;
                }
            }

            return (maxNumber, minNumber, sum);
        }

        private static (int radius, double circumference, double area) Circle()
        {
            int radius = GetNumber("Enter the first number:");
            double circumference = CalculateCircumference(radius);
            double area = CalculateArea(radius);

            return (radius, circumference, area);
        }

        private static double CalculateCircumference(int radius)
        {
            return 2 * Math.PI * radius;
        }

        private static double CalculateArea(int radius)
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
    }
}
