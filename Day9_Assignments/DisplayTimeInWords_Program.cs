using System;
namespace TimeInWords
{
    class DisplayTimeInWords
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Hours : ");
            int hours = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Minutes : ");
            int minutes = int.Parse(Console.ReadLine());

            string timeInWords = GetTimeInWords(hours, minutes);
            Console.WriteLine(timeInWords);
        }
        public static string GetTimeInWords(int hours, int minutes)
        {
            string[] numbers = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven",
            "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen",
                "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty" };

            if (minutes == 0)
            {
                return $"{numbers[hours]} 0' clock";
            }
            else if (minutes == 1)
            {
                return $"one minute past {numbers[hours]}";
            }
            else if (minutes == 15)
            {
                return $"quater past {numbers[hours]}";
            }
            else if (minutes == 30)
            {
                return $"Half past {numbers[hours]}";
            }
            else if (minutes < 20)
            {
                return $"{numbers[minutes]} minutes past {numbers[hours]}";
            }
            else if (minutes < 30)
            {
                return $"twenty {numbers[minutes % 10]} minutes past {numbers[hours]}";
            }
            else if (minutes == 45)
            {
                return $"quarter to {numbers[(hours % 12) + 1]}";
            }
            else
            {
                int remainingMinutes = 60 - minutes;
                if (remainingMinutes < 20)
                {
                    return $"{numbers[remainingMinutes]} minutes to {numbers[(hours % 12) + 1]}";
                }
                else
                {
                    return $"Twenty {numbers[remainingMinutes % 10]} minutes to {numbers[(hours % 12) + 1]}";
                }

            }
        }
    }
}
 
        

     