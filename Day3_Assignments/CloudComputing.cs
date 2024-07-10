using System;
using System.Data.SqlTypes;
namespace CloudComputing
{
    class program_9
    {
        public static void Main(string[] args)
        {
            int courseFees = 25000;

            DateTime d = new DateTime();
            Console.WriteLine(d.ToString("21/06/2024"));


            Console.WriteLine("Enter the Subscriber Id : ");
            int sId =int.Parse( Console.ReadLine());

            Console.WriteLine("Enter the Subscriber Name : ");
            String sName = Console.ReadLine();

            Console.WriteLine("Enter the Subscriber Phone Number: ");
            long sPhone =long.Parse( Console.ReadLine());

            Console.WriteLine("Enter the Registered date : ");
            DateTime rDate = DateTime.Parse(Console.ReadLine());

            DateTime d1 = new DateTime(2024, 06, 10);
            DateTime d2 = new DateTime(2024, 06, 15);
            DateTime d3 = new DateTime(2024, 06, 20);


            if (rDate < d1)
            {
                double afterTenPerDis = courseFees - (courseFees * 0.01);
                Console.WriteLine("After 10% discount Course Fees is : " + afterTenPerDis);

            }
            else if (rDate < d2)
            {
                double afterFifteenPerDis = courseFees - (courseFees * 0.15);
                Console.WriteLine("After 15% discount Course Fees is : " + afterFifteenPerDis);

            }
            if (rDate > d3)
            {
                double afterFivePerPenality = courseFees + (courseFees * 0.05);
                Console.WriteLine("After 5% on penality for late the Course Fees is : " + afterFivePerPenality);

            }

            Console.WriteLine("-------Subscriber Details------");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Subscriber Id : " + sId);
            Console.WriteLine("Enter the Subscriber Name : " + sName);
            Console.WriteLine("Enter the Subscriber Phone Number: " + sPhone);
            Console.WriteLine("Enter the Registered date : " + rDate);









        }
    }
}