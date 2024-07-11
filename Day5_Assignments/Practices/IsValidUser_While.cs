using System;
namespace ValidUser_Function
{
    class ValidUser_Function
    {
        static bool IsValidUser(string userId, string password)
        {
            if(userId.Trim() == "admin" && password.Trim()=="admin123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Main(string[] args)
        {
            int count = 1;
            while(count <= 3)
            {
                Console.WriteLine("Enter User Id: ");
                string userId = Console.ReadLine();

                Console.WriteLine("Enter User Password: ");
                string password = Console.ReadLine();

                bool result = IsValidUser(userId, password);

                if(result )
                {
                    Console.WriteLine("Welcome to {0}, ", userId);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid User Id or password. Wrong attempts count : " + count);

                        if (count == 3)
                        Console.WriteLine("Your account is locked. ");
                        count++;
                }
            }
        }
    }
}