using System;
namespace Array_Collection
{
    class Array_Collection
    {
        public static void Main(string[] args)
        {
            //finf array length
            int[] arr = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Size of the Array : " + arr.Length);

            //Index based
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ",arr[i]);
            }
            Console.WriteLine();

            //Item based using foreach
            foreach(int item in arr)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            

            //Reverse the array
            for(int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();

        }
    }

}
    