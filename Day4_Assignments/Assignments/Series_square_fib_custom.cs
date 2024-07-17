using System;
namespace Series
{
    class PerfectSquares
    {
        public static void Main(string[] args)
        {


            // 1 4 9 16 25 36 49 64 81 100------Squares
            Console.WriteLine("-----squares of the numbers-----");
            for(int i=1; i<=10; i++)
            {
                int square = i * i;
                Console.Write("{0} ",square);
            }
            Console.WriteLine("\n----------------");

            // 0 1 1 2 3 5 8 13 21 34 55 89 144 -----Fibonacci Series

            int f1 = 0, f2 = 1, f3;
            for (int i = 0; i <= 10; i++)
            {
                f3 = f1 + f2;

                Console.Write("{0} ", f3);
                f1 = f2;
                f2 = f3;
            }
            Console.WriteLine("\n----------------");

            // 3 5 6 9 10 12 15 18 20 21 24 25 27 30
            int j = 3;
            do
            {
                if (j% 3 == 0 || j % 5 == 0)
                {
                    Console.Write("{0} ", j);

                }
                j++;
            } while (j <= 30);
            Console.WriteLine(" ");

        }
    }
}