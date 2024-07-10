using System;
namespace UserLogib
{
    public class UserLogin
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the User Id : ");
            string userId = Console.ReadLine();
         
           // string S = string.Format(userId, Console.ReadLine());   

            Console.WriteLine("Enter the Password : ");
            string password = Console.ReadLine();

            if (userId.Trim().ToLower() == "admin" &&  password.Trim().ToLower == "admin123")
            {
                Console.WriteLine("Welcome to Admin");
            }
            else
            {
                Console.WriteLine("Inavlid User id or Password");
            }

        }
    }
}
