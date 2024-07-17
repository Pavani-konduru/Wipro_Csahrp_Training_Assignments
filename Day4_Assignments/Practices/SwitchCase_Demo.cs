using System;
namespace SwitchCase_Demo
{
    public class Program5
    {
        static void Main(string[] args)
        {
            const int SALES_DEPARTMENT = 10;
            const int ADMIN_DEPARTMENT = 20;
            const int ACCOUNTS_DEPARTMENT = 30;
            const int OPERATIONS_DEPARTMENT = 40;

            Console.WriteLine("Enter your Dept NO: ");
            int dno = int.Parse(Console.ReadLine());

            switch (dno)
            {
                case SALES_DEPARTMENT:
                    Console.WriteLine("Your Belongs to Sales Department");
                    break;
                case ADMIN_DEPARTMENT:
                    Console.WriteLine("Your Belongs to Admin Department");
                    break;
                case ACCOUNTS_DEPARTMENT:
                    Console.WriteLine("Your Belongs to Accounts Department");
                    break;
                case OPERATIONS_DEPARTMENT:
                    Console.WriteLine("Your Belongs to Operation Department");
                    break;
                default:
                    Console.WriteLine("Invalid Dept Number");
                    break;



            }
        }
    }
}

               


                    
            