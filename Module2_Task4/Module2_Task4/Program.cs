using System;

namespace Module2_Task4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Выбрать фигуру для расчетов: ");
            Console.WriteLine("for a triangle: press 1");
            Console.WriteLine("for a circle: press 2");
            Console.WriteLine("for a square: press 3");

            var line = Console.ReadLine();
            int choice;
            if (!int.TryParse(line, out choice))
            {
                Console.Clear();
                Console.WriteLine("Wrong data input, try again input only digits");
            }
            else
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You have chosen a triangle ");
                        break;
                    case 2:
                        Console.WriteLine("You have chosen a circle ");
                        break;
                    case 3:
                        Console.WriteLine("You have chosen a square ");
                        break;
                    default:
                        Console.WriteLine("Error! No such item!!!");
                        break;
                }
            }

            Console.WriteLine("Choose what to counts: ");
            Console.WriteLine("Count area: 1 ");
            Console.WriteLine("Count perimeter: 2");

            var select = Console.ReadLine();
            int choice1;
            if (!int.TryParse(select, out choice1))
            {
                Console.WriteLine("Wrong, data input, try again input only digits");
            }
            else
            {
                switch (choice1)
                {
                    case 1:
                        Console.WriteLine("Area ");
                        Console.WriteLine("Insert the number: ");
                        double a = Convert.ToInt32(Console.ReadLine());
                        double area = (a + a + a) / 2;
                        double triangleArea = Math.Sqrt(area * (area - a) * (area - a) * (area - a));
                        double squareArea = a * a;
                        double circleArea = squareArea * 3.14;
                        Console.WriteLine("Area triangle: " + triangleArea);
                        Console.WriteLine("Area square: " + squareArea);
                        Console.WriteLine("Area circle: " + circleArea);
                        break;

                    case 2:
                        Console.WriteLine("Perimeter ");
                        Console.WriteLine("Insert the number: ");
                        double b = Convert.ToInt32(Console.ReadLine());
                        double perimeter = (b + b + b) / 2;
                        double trianglePerimeter = 3 * b;
                        double squarePerimeter = 4 * b;
                        double circlePerimeter = 2 * ((2 * b) * 3.14);
                        Console.WriteLine("Perimeter triangle: " + trianglePerimeter);
                        Console.WriteLine("Perimeter square: " + squarePerimeter);
                        Console.WriteLine("Perimeter circle: " + circlePerimeter);
                        break;

                    default:
                        Console.WriteLine("Error! No such item!!!");
                        break;

                }
            }

            Console.ReadKey();
        }
    }
}
