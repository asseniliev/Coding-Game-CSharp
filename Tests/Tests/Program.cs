using System;

namespace Tests
{
    

    class Program
    {
        public static int Solve(int weight0, int weight1, int weight2)
        {
            // Write your code here
            // To debug: Console.Error.WriteLine("Debug messages...");

            if (weight0 >= weight1)
            {
                if (weight1 >= weight2)
                    return 0;
                else if (weight0 >= weight2)
                    return 0;
                else
                    return 2;
            }
            else
            {
                if (weight1 >= weight2)
                    return 2;
                else
                    return 1;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(3, 4, 5));
        }
    }
}
