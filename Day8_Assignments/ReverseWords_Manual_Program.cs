
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWords_Manual
{
    class ReverseWords
    {
        static string StringReverse(string inputStr, int start, int end)
        {
            char[] chars = inputStr.ToCharArray();
            char temp;

            while (start <= end)
            {
                temp = chars[start];
                chars[start] = chars[end];
                chars[end] = temp;
                start++;
                end--;
            }

            string result = new string(chars);
            // Console.WriteLine(result);
            return result;
        }

        static string StringReverseWords(string inputStr)
        {
            string result = "";
            char[] chars = inputStr.ToCharArray();

            int start = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == ' ')
                {
                    chars = StringReverse(new String(chars), start, i - 1).ToCharArray();
                    start = i + 1;
                }
            }

            // to reverse the last word
            chars = StringReverse(new String(chars), start, chars.Length - 1).ToCharArray();

            result = new String(chars);

            // to reverse the complete sentence 
            result = StringReverse(result, 0, result.Length - 1);

            return result;
        }
        static void Main(string[] args)
        {
            //    Console.WriteLine("Enter a message: ");
            //            string input = Console.ReadLine();
            string input = "Hi Welcome to C# Programming Language Class";
            string output = StringReverseWords(input);

            Console.WriteLine("Input : " + input);
            Console.WriteLine("Output : " + output);

            Console.ReadLine();
        }
    }
}