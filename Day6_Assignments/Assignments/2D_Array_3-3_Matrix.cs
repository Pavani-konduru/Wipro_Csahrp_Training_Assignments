using System;
using System.Numerics;
namespace twoD_Array_User
{
    class twoD_Array_User
    {
        public static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            Console.WriteLine("Enter the Elements for 3*3 Matrix");

            //Read the Elements from the User
            for(int i=0; i< 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Element[{i},{j}]: ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //Display the Array
            Console.WriteLine("The 3*3 Matrix is : ");
            for(int i=0; i< 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{arr[i, j]}\n");
                }
                Console.WriteLine();

            }



        }
    }
}