using System;
namespace Even_Odd
{
    class Even_Odd
    {
        public static void Main(string[] args)
        {
            int evenSum = 0;
            int oddSum = 0;
            Console.WriteLine("Enter the 20 Numbers :");

            for(int i=0; i<20; i++)
            {
                Console.WriteLine($"Enter number { i + 1} : ");
                int num = int.Parse( Console.ReadLine() );

                if(num % 2 ==0)
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num;
                }
            }
            Console.WriteLine($"sum of Even numbers: {evenSum}");
            Console.WriteLine($"sum of Even numbers: {oddSum}");

        }
    }
}