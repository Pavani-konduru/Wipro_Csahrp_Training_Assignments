// Write a C# program to seperate Even and Odd Numbers into separate Arrays from the given array

using System;
namespace Seperate_Even_Odd
{
    class Seperate_Even_Odd 
    {
        static void PrintArray(int[] arr)
        {
            foreach(int item in arr)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

        }
        static int GetEvenCount(int[] arr)
        {
            int count = 0;
            foreach (int item in arr)
            {
                if (item % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
        static int GetOddCount(int[] arr)
        {
            int count = 0;
            foreach (int item in arr)
            {
                if (item % 2 == 1)
                {
                    count++;
                }
            }
            return count;
        }
        public static void Main(string[] args)
        {
            int[] arr = { 3, 5, 12, 16, 17, 19, 23, 26, 28 };

            int evenCount = GetEvenCount(arr);
            int oddCount = GetOddCount(arr);

            int[] evenArray = new int[evenCount];
            int[] oddArray = new int[oddCount];

            int evenIndex = 0;
            int oddIndex = 0;

            foreach(int item in arr) 
            {
                if (item % 2 == 0)
                {
                    evenArray[evenIndex] = item;
                    evenIndex++;
                }
                else
                {
                    oddArray[oddIndex] = item;
                    oddIndex++;

                }
            }

            PrintArray(arr);
            PrintArray(oddArray);

            Console.WriteLine();


        }
    
    }
}