using System;
namespace Date
{
    class Date
    {
        public static void Main(string[] args)
        {
            //Default time 
            DateTime d = new DateTime();
            Console.WriteLine("Default time and date " + d); //01-01-0001

            //current Date and Time
            d = DateTime.Now;
            Console.WriteLine("Current Date and time "+ d); //09-07-2024 11:32:34

            //to get date after 10 days of today's date-------1
            d = DateTime.Today;
            Console.WriteLine(d);
            Console.WriteLine("After 10 days of Todays Date : " + d.AddDays(10));

            //how to find No.of days between the two dates------2
            DateTime d1 = DateTime.Today;
            DateTime d2 = DateTime.Now.AddDays(2);
            TimeSpan t = d1 - d2;
            Double noOfDays= t.TotalDays;
            Console.WriteLine("Difference Between 2 days: " + noOfDays);

            //how to display the given format using ToString()------3
            //Tuesday, 9 july, 2024 at 11:28 AM

            d = DateTime.Today;
            Console.WriteLine(d.ToString("dddd, dd MMMM, yyyy 'At' hh:mm tt"));

        }
    }
}