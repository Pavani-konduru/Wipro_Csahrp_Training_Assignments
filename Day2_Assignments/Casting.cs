using System;
namespace Casting
{
    class program_10
    {
        public static void Main(string[] args)
        {
            int x1 = 23;
            double d1 = 34.87;
            bool b1 = true;

            Console.WriteLine("---Original-----");
            Console.WriteLine(x1);
            Console.WriteLine(d1);
            Console.WriteLine(b1);

            Object obj;
            obj = x1; //boxing-------Implicit casting
            int x2 =(int) obj; //Unboxing------Explpicit casting

            obj = d1;
            double d2 = (double)obj;

            obj = b1;
            bool b2 = (bool)obj;

            Console.WriteLine("----Casting-----");
            Console.WriteLine(x1);
            Console.WriteLine(d2);
            Console.WriteLine(b2);
            

        }
    }
}