using System;
namespace Factorial_Function
{
    class Factorial_Function
    {
        static int factorial(int n)
        {
            if(n == 0)
                return 1;
            return  n* factorial(n-1);
            
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number : ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Factorial of " + num + " is " + factorial(num));
        }
    }
}