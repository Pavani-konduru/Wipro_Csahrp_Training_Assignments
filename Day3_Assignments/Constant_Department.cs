using System;
namespace Constant_Department
{
    static class DeptConstants
    {
        public const int SALES_DEPARTMENT = 10;
        public const int ADMIN_DEPARTMENT = 20;
        public const int ACCOUNTS_DEPARTMENT = 30;
        public const int OPERATIONS_DEPARTMENT = 40;
    }
    public class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Dept NO: ");
           int dno= int.Parse( Console.ReadLine());

            if(dno == DeptConstants.SALES_DEPARTMENT)
            {
                Console.WriteLine("Your Belongs to Sales Department");
            }
            if (dno == DeptConstants.ADMIN_DEPARTMENT)
            {
                Console.WriteLine("Your Belongs to Admin Department");
            }
            if (dno == DeptConstants.ACCOUNTS_DEPARTMENT)
            {
                Console.WriteLine("Your Belongs to Accounts Department");
            }
            if (dno == DeptConstants.OPERATIONS_DEPARTMENT)
            {
                Console.WriteLine("Your Belongs to Operation Department");
            }
        }
    }
}