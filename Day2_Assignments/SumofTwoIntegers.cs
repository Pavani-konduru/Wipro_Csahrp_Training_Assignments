using System;
namespace SumOfTwoIntegers
{
    class Program6
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Number");
            long num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Second Number");
            long num2 = int.Parse(Console.ReadLine());

            long sum = num1 + num2;
            Console.WriteLine("The sum of two integers is : " + sum);
        }
    }
}