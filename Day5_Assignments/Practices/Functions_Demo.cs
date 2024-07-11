using System;
namespace Function_Demo
{
    class Function_Demo
    {
        static void Hello()
        {
            Console.WriteLine("Hi, Good Morning..!");
        }
         static void Greeting(string uname)
        {
            Console.WriteLine("Hi {0}, How are You ", uname);               
        }
         static int sum(int x, int y)
        {
            return x + y;
        }
        static String GetCurrentUserName()
        {
            return "scott";
        }
        public static void Main(string[] args)
        {
            Hello(); ;
            Greeting("Smith");

            int res = sum(10, 20);
            Console.WriteLine("Sum Result : " + res);

            String str = GetCurrentUserName();
            Console.WriteLine("Get Current User Name result : " +  str);

        }
    }
}