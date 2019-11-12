using System;

namespace Module4_Task8
{
    class Program
    {
        static void Main(string[] args)
        {

            double start = -2;
            double end = 7;
            double epsilon = 0.001;
            double x = GetX(start, end, epsilon);

            Console.WriteLine($"Result X = {x}");
            Console.WriteLine($"Result F(x) = {GetF(x)}\n");
            Console.ReadKey();
        }

        private static double GetX(double start, double end, double epsilon)
        {
            double x = (end + start) / 2;
            if (Math.Abs(GetF(x)) > epsilon)
            {
                if (GetF(x) > 0)
                {
                    return GetX(start, end = x, epsilon);
                }
                else
                {
                    return x = GetX(start = x, end, epsilon);
                }
            }

            else
            {
                return x = (start + end) / 2;
            }
        }

        private static double GetF(double x)
        {
            double f = Math.Pow(x, 3) - 6 * Math.Pow(x, 2) + 12 * x - 8;

            return f;
        }
    }
}
