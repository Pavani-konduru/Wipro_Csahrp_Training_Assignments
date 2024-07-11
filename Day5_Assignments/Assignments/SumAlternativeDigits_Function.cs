using System;
namespace SumOfAlternativeDigits_function
{
    class SumOfAlternativeDigits_function
    {
        static int sumAlternativeDigits(int n)
        {
            int sum = 0;
            while(n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
        static void getSum(int n)
        {
      
           
        }
        public static void Main(string[] args)
        {
            int n = sumAlternativeDigits(12345);

            Console.WriteLine("Enter the number : ");
            int num = int.Parse(Console.ReadLine());
            int sumOdd = 0;
            int c = 1;
            while (n != 0)
            {
                if (c % 2 != 0)
                    sumOdd += n % 10;
                c /= 10;
                c++;
            }
            Console.WriteLine("The sum of Alternative digits in the Given number : " + sumOdd);
            getSum(num);

        }
    }
}