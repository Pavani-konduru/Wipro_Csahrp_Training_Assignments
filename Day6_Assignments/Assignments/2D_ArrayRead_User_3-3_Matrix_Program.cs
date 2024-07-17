using System;
using System.Numerics;
namespace twoD_Array_User
{
    class twoD_Array_User
    {
        // Write a C# Program to read 2D Array elements from user Consider 3*3 Matrix
        public static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            Console.WriteLine("Enter the Elements for 3*3 Matrix");

            //Read the Elements from the User
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Element[{i},{j}]: ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine(" Successfully Read the Elements for 3*3 Matrix");

        }
    }   }  