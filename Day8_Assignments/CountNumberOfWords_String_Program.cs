using System;
using System.ComponentModel.DataAnnotations;
namespace NumberOfWordsString
{   
    class NumberOfWords_String
    {
        public static void Main(string[] args)
        {
            int count = 1,len = 0;
            Console.WriteLine("Enter the Sentence");
            string input = Console.ReadLine();
            while (len<= input.Length - 1)
            {

                if (input[len]==' ' || input[len] =='\n' || input[len]=='\t')
                {
                    count++;
                }
                len++;
            }
            Console.WriteLine($"Total Number of Words in the String is : " + count);
            Console.WriteLine();
        }                 
            }
        }
  