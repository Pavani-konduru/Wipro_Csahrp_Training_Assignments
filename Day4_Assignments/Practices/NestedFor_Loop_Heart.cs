using System;
namespace NestedFor_Loop_Heart
{
    class NestedFor_Loop_Heart
    {
        public static void Main(string[] args)
        {

            Console.OutputEncoding =System.Text.Encoding.UTF8;

            Console.WriteLine("Enter the NUmber of Lines : ");
            int n = int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write('\u2665' + " ");
                }
                Console.WriteLine();
            }

            for (int i = n-1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('\u2665' + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


        }
    }
}