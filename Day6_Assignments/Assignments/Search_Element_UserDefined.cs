using System;
using System.Security.Cryptography.X509Certificates;
namespace ArraySearching_1
{
    class ArraySearching_1
    {
        static int FindElementInArray(int[] arr, int find)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == find)
                {
                    return i;
                }
            }
            return -1;
        }
        public static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50, 60, 70 };

            Console.WriteLine("Enter the Element to Search : ");
            int n = int.Parse(Console.ReadLine());

            int result = FindElementInArray (arr, n);
            if(result != -1)
            {
                Console.WriteLine("Yes.. Element Exists in the Array");
            }else
            {
                Console.WriteLine("Element doesn't Exixt in the array");
            }
        }
    }
}   