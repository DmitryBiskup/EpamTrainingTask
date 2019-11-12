using System;

namespace Module4_Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5];
            Random rand = new Random();
            for (int i = 0; i < myArray.Length; i++)
                myArray[i] = rand.Next(0, 50);

            Console.Write("Array before change: ");
            Console.WriteLine(string.Join("|", myArray));

            BubbleSort(myArray);
            UnBubbleSort(myArray);

            Console.ReadKey();
        }

        static void BubbleSort(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length - 1; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        int z = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = z;
                    }
                }
            }
            Console.Write("Sorted ascending: ");
            Console.WriteLine(string.Join(" ", A));
        }

        static void UnBubbleSort(int[] B)
        {
            for (int i = 0; i < B.Length; i++)
            {
                for (int j = 0; j < B.Length - 1; j++)
                {
                    if (B[j] < B[j + 1])
                    {
                        int z = B[j];
                        B[j] = B[j + 1];
                        B[j + 1] = z;
                    }
                }
            }

            Console.Write("Sorted descending: ");
            Console.WriteLine(string.Join(" ", B));
        }
    }
}
