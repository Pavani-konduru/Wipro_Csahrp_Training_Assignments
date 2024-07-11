using System;
namespace WordOfStringToNewLine
{
    class WordOfStringToNewLine
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Sentence : ");
            string inputString = Console.ReadLine();

            string[] output = inputString.Split(' ');
            Console.WriteLine("Split string into new line by line : ");
          

            foreach(string parts in output)
            {
                Console.WriteLine(parts);
            }
        }
    }
}