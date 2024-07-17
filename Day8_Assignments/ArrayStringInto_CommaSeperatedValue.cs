using System;
namespace Array_CommaSeperatedValue
{
    class ArrayOfString_CommaSeperatedValue
    {
        public static void Main(string[] args)
        {
            string[] array = { "Books" , " Pens", " charts "};
            string result = ConvertArrayToCommaSeperatedValue(array);
            foreach(string str in array)
            {
                Console.Write(" {0}",str);
            }
            
            Console.WriteLine("Output : " + result );
        }
        static string ConvertArrayToCommaSeperatedValue(string[] arr)
        {
            if(arr == null || arr.Length == 0)  
            return string.Empty;
            string seperator = ",";
            string commaSeperatedValueString = arr[0];

            for(int i =1; i < arr.Length; i++)
            {
                commaSeperatedValueString += seperator + arr[i];
            }
            return commaSeperatedValueString;
        }
    }
}
