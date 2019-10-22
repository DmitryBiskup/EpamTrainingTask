using System;

namespace Module2_Task3
{
    class Program
    {
        private static bool ba;

        static void Main()
        {
            Console.WriteLine("Insert the numbers а: ");

            double a;
            while (!Double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Input error! Insert the numbers");
            }

            Console.WriteLine("Insert the numbers b: ");

            double b;

            while (!Double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Input error! Insert the numbers");
            }

            string check = Console.ReadLine();

            if (check != null && check.Contains(",") || check != null && check.Contains("."))
            {
                if (check.Contains("."))
                {
                    check = check.Replace(',', '.');
                }

                double fraction;

                if (double.TryParse(check, out fraction))
                {
                    fraction = Convert.ToDouble(check);

                    Console.WriteLine(string.Format("first number : {0}", fraction));

                    ba = true;
                }

                else
                {
                    Console.WriteLine("Input error! try again");
                    Console.ReadLine();
                }
            }

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("Number а: " + a);

            Console.WriteLine("Number b: " + b);
            Console.ReadKey();

        }
    }
}
