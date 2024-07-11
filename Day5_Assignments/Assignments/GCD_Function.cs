using System;
namespace Gcd_Function
{
    class Gcd_Function
    {
        static int FingGCD(int num1, int num2)
        {
            while(num2 != 0)
            {
                int temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }
            return num1;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first Number : ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Second Number : ");
            int y= int.Parse(Console.ReadLine());

           int gcd = FingGCD(x, y);
            Console.WriteLine($"The GCD of {x} and {y} is {gcd}");


        }
    }
}