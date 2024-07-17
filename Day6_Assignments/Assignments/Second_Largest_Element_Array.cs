using System;
namespace SecondLargest_Element_Array
{
    class SecondLargest_Element_Array
    {
        public static void Main(string[] args)
        {
            int[] array = new int[] { 35, 24, 55, 77, 22, 10 };
           foreach(int item in array)
            {
                Console.Write("{0} ", item);
            }
           Console.WriteLine();

            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            foreach (int i in array)
            {
                if (i > largest)
                {
                    secondLargest = largest;
                    largest = i;
                }
                else if (i > secondLargest)
                {
                    secondLargest = i;
                }

            }

            Console.WriteLine("Second Largest Element : " + secondLargest);
        }
    }
}