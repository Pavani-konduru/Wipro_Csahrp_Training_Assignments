
namespace FirstConsoleApp
{
    class Amstrong
    {
        public static void Main(string[] args)
        {
            int num, m, sum = 0, r;

            Console.WriteLine("Enter the Number");
            num = Convert.ToInt32(Console.ReadLine());
            m= num;
            while(m!=0)
            {
                r = m % 10;
                sum = sum + (r * r * r);
                m = m / 10;
            }
            if (sum == num)
            {
                Console.WriteLine("The Entered Number is an Amstrong Number ");
            }
            else
            {
                Console.WriteLine("The Entered Number is not an Amstrong Number");
            }
            }
        }
    }


