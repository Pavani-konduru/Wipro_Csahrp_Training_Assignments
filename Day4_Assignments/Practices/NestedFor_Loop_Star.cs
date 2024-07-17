using System;
namespace NestedFor_Loop_Star
{
    class NestedFor_Loop_Star
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of Lines: ");
            int n = int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();             
            }
            for (int i = n-1; i >= 1; i--)
            {
                for(int j = 1; j<= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }
            Console.WriteLine();
            

            
        }
    }
}