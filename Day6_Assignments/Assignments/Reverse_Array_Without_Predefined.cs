//Write a C# program to Reverse an array Elements without using Predefined Methods 

using System;
namespace Reverse_Array
{
    class Reverse_Array
    {
        public static void Main(string[] args)
        {
            int[] array = new int[] { 10,20,30,40,50,60,70};

            for(int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine("\n");

            for(int i = array.Length-1; i >= 0; i--)
            {
                Console.Write("{0} ", array[i]);

            }
            Console.WriteLine("\n");

        }
    }
}