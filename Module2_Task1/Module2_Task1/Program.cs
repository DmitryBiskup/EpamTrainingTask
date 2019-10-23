using System;

namespace Module2_Task1
{
    class Program
    {
            const int allIncome = 500;
            private static int percentOfTax;
            private static int countOfCompanies;

        static void Main()
        {
            Console.WriteLine("Enter the number of companies: ");

            while (!Int32.TryParse(Console.ReadLine(), out countOfCompanies))
            {
                Console.WriteLine("Input Error! Enter an integer");
            }

            Console.WriteLine("Enter tax percentage: ");

            while (!Int32.TryParse(Console.ReadLine(), out percentOfTax))
            {
                Console.WriteLine("Input Error! Enter the percentage in numbers");
            }

            int totalTax = (allIncome / 100) * percentOfTax;

            Console.WriteLine("The amount of state revenue with " + countOfCompanies + " companies: " + totalTax);
            Console.ReadKey();
        }
    }
}
