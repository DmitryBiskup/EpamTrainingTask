using System;

namespace Module3_Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray;
            Console.WriteLine("Enter the size of the array n= ");
            int n = int.Parse(Console.ReadLine());
            myArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("A[{0}]= ", i);
                myArray[i] = int.Parse(Console.ReadLine());
            }
            foreach (int elem in myArray)
            {
                Console.Write(" {0} ", elem);
            }

            Change(myArray, n);
            Console.WriteLine("Change array ");
            foreach (int elem in myArray)
            {
                Console.Write("{0} ", elem);
            }

            Console.ReadKey();
        }

        static void Change(int[] myArray, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (myArray[i] < 0 || myArray[i] > 0)
                {
                    myArray[i] *= -1;
                }
            }
        }
    }
}
