using System;
namespace NumberofEqual_Words_String
{
    class NumberofEqual_Words_String
    {
        public static int FindNumberOfWords_EqualLength(string input)
        {
            string[] strArr = input.ToString().Split(' ');
            int count = 0;
            for(int i =0; i<strArr.Length-1; i++)
            {
                int found = 1;
                for(int j=i+1; j<strArr.Length; j++)
                {
                    if (strArr[i].Length == strArr[j].Length)
                    {               
                      found++;
                    }
                }
                if(found >count && found>1)
                {
                    count = found;
                }
            }
            return count;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the String : ");
            string? input = Console.ReadLine();
            Console.WriteLine(FindNumberOfWords_EqualLength (input) + " Words with same Length of characters ");
          /*  Console.WriteLine("Enter a String: ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] wordLengthCounts = new int[50]; // Assuming maximum word length of 100
            foreach (string word in words)
            {
                int length = word.Length;
                wordLengthCounts[length]++;
            }
            int equalLengthWordsCount = 0;
            foreach (int count in wordLengthCounts)
            { 
                if (count > 1)
                {
                    equalLengthWordsCount += count;
                }
                Console.WriteLine("Number of words that have equal number of characters: " + equalLengthWordsCount);


            }
      */  }
    }
}