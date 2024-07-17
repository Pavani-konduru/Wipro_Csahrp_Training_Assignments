using System;
namespace SumOfMaxNum
{
    class SumOfMaxNum
    {
        public static void Main(string[] args)
        {
            int MaxValue1 = int.MinValue;
            int MaxValue2 = int.MaxValue;
            try
            {
                int result = checked(MaxValue1 + MaxValue2);
                Console.WriteLine("Sum of two Integers: " + result);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow Occured With the appropriate data type.");
                long safeResult = (long)MaxValue1 + MaxValue2;  
                Console.WriteLine("Safe sum of two Max integers : " + safeResult);

            }
        }
    }
}