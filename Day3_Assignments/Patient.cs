using System;
namespace Patient
{
    class program8
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Patieint ID Number : ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Patieint Name : ");
            string name = (Console.ReadLine());

            Console.WriteLine("is Old Patient : ");
            bool isOld  = bool.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Age of the Patient : ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Weight of the Patient : ");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Patient Body Temperature : ");
            double pTemp = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Amount  : ");
            double amount = double.Parse(Console.ReadLine());


            DateTime d = new DateTime();
            Console.WriteLine("Enter the Joining Date and Time (dd/mm/yyyy) : ");
            d = DateTime.Parse(Console.ReadLine());
            

            Console.WriteLine("-------Patient Details-------");


            Console.WriteLine("Enter the Patieint ID Number : " + id);
            Console.WriteLine("Enter the Patieint Name : " + name);
            Console.WriteLine("is Old Patient : " + isOld);
            Console.WriteLine("Enter the Age of the Patient : " + age);
            Console.WriteLine("Enter the Weight of the Patient : " + weight);
            Console.WriteLine("Enter the Patient Body Temperature : " + pTemp);
            Console.WriteLine("Enter the Amount  : " + amount);
            Console.WriteLine("Enter the Joining Date and Time : " + d);













        }
    }
}