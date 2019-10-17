using System;

namespace Module2_2
{
    class Program
    {
        private static int agePerson;

        static void Main()
        {
            Console.WriteLine("Enter age: ");

            while (!Int32.TryParse(Console.ReadLine(), out agePerson))
            {
                Console.WriteLine("Input Error! Enter the age in numbers");
            }

            if (agePerson > 18 && agePerson % 2 == 0)
            {
                Console.WriteLine("Congratulations on coming of age");
            }
            else if (agePerson % 2 != 0 && agePerson < 18 && agePerson > 13)
            {
                Console.WriteLine("Congratulations on conversion to high school");
            }

            Console.ReadKey();
        }
    }
}
