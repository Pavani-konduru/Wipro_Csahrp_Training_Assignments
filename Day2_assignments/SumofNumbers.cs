namespace SumOfNumbers
{
    class Sumofdigits
    {
        public static void Main(string[] args)
        {
            int NUM,sum = 0;
            Console.WriteLine("Enter the Number ");
            int num = Convert.ToInt32(Console.ReadLine());

            while(num != 0)
            {
                sum = sum + num % 10;
                num = num / 10;
            }
            Console.WriteLine("The sum of the Digits of a given Num is : " + sum);
        }
    }
}