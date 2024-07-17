using System;
namespace Patterns
{
    class Patterns
    {
        public static void Main(string[] args)
        {
            for(int i =1; i<=5; i++)
            {
                for(int j=1; j<=i;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("------------------");
            for(int i =1; i<=5; i++)
            {
                for (int j=1; j<=i; j++)
                {
                    Console.Write("{0} ", i);

                }
                Console.WriteLine();

            }
        }

    }
}