using System;
namespace TwoD_Array
{
    class TwoD_Array
    {
        public static void Main(string[] args)
        {
            //2D Array
            int[,] arr = new int[,]
            {
                {2,4,6 },
                { 3,6,8 },
                { 4,8,12}
            };
            Console.WriteLine("Length is : " + arr.Length);
            Console.WriteLine("\n----");

            for(int i = 0; i< arr.GetLength(0); i++)
            {
                for(int j = 0; j< arr.GetLength(1); j++)
                {
                    Console.Write(" "  + arr[i, j]);

                }

                Console.WriteLine();
            }
            Console.WriteLine("\n----");

            Console.WriteLine("Rank of the Array : " + arr.Rank);
            Console.WriteLine();
            }
    }
}
