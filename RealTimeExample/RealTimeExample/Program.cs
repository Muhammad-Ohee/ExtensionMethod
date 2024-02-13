//Console.WriteLine("Hello, OS");

namespace RealTimeExample
{
    public static class StringExtension
    {
        public static int GetWordCount(this string inputString)
        {
            if (!string.IsNullOrEmpty(inputString))
            {
                string[] strArray = inputString.Split(' ');
                return strArray.Count();
            }
            else 
            { 
                return 0;
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            string myWord = "Welcome to Extension Methods";
            int wordCount = myWord.GetWordCount();
            Console.WriteLine("string : " + myWord);
            Console.WriteLine("Count : " + wordCount);
        }
    }
}