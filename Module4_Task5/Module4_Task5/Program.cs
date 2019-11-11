using System;

namespace Module4_Task5
{
    class Program
    {
        enum Operation
        {
            Add = 1,
            Subtract = 2,
            Multiply = 3,
            Divide = 4
        }

        static void MathOperations(double x, double y, Operation operation)
        {
            double result = 0;

            switch (operation)
            {
                case Operation.Add:
                    result = x + y;
                    break;
                case Operation.Subtract:
                    result = x - y;
                    break;
                case Operation.Multiply:
                    result = x * y;
                    break;
                case Operation.Divide:
                    result = x / y;
                    break;
            }
            Console.WriteLine("The result of the operation is: {0} ", result);
        }

        private static void DateTimeDaysInMonth(int year, int month)
        {
            var daysInMonth = DateTime.DaysInMonth(year, month);
            Console.WriteLine("This month: " + daysInMonth + " day");
        }

        static void Main(string[] args)
        {
            MathOperations(-15, 27, Operation.Add);
            MathOperations(12, -33, Operation.Subtract);
            MathOperations(2, 19, Operation.Multiply);
            MathOperations(48, 5, Operation.Divide);

            DateTimeDaysInMonth(2019, 9);
            DateTimeDaysInMonth(2016, 2);
            DateTimeDaysInMonth(2018, 4);

            Console.ReadKey();
        }
    }
}