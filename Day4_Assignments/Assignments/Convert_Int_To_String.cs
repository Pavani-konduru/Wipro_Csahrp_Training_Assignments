using System;
namespace ConvertIntToString
{
    class ConvertIntToString
    {
        public static void Main(string[] args)
        {
            int num, sum = 0, r;
            Console.WriteLine("Enter the Number");
            num = int.Parse(Console.ReadLine());

            while (num > 0)
            {
                r = num % 10;
                sum = sum * 10 + r;
                num = num / 10;

            }
            num = sum;
            while (num > 0)
            {
                r = num % 10;


                switch (r)
                {
                    case 0:
                        Console.Write("zero ");
                        break;
                    case 1:
                        Console.Write("One ");
                        break;
                    case 2:
                        Console.Write("Two ");
                        break;
                    case 3:
                        Console.Write("Three ");
                        break;
                    case 4:
                        Console.Write("Four ");
                        break;
                    case 5:
                        Console.Write("Five ");
                        break;
                    case 6:
                        Console.Write("Six ");
                        break;
                    case 7:
                        Console.Write("Seven ");
                        break;
                    case 8:
                        Console.Write("Eight ");
                        break;
                    case 9:
                        Console.WriteLine("Nine");
                        break;
                    default:Console.Write("Null ");
                        break;

                }
                num = num / 10;
            }
        }
    }
}