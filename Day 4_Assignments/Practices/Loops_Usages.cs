using System;
namespace LoopUsages
{
    class LoopUsages
    {
        public static void Main(string[] args)
        {
            int i;
            // print 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20
            //while Loop
            i = 1;
            while (i <= 20)
            {
                Console.Write("{0} ", i);
                i++;
            }
            Console.WriteLine("\n-------------");

            //0 2 4 6 8 10 12 14 16 18 20
            //do-While loop
            i = 0;
            do
            {
                Console.Write("{0} ", i);
                i = i + 2;

            }while (i <= 20);
            Console.WriteLine("\n-------------");

            //1 2 3 4 5 6 7 8 9 10
            //for loop

            for(int j =1; j<=10; j++)
            {
                Console.Write("{0} ", j);
            }
            Console.WriteLine("\n-------------");

            //50 45 40 35 30 25 20 15 10 5 
            //For Loop

            for(int j =50; j >= 5; j = j-5) 
            {
                Console.Write("{0} ", j);
            }
            Console.WriteLine("\n-------------");



        }
    }
}