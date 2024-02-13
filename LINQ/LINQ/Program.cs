//Console.WriteLine("Hello, World!");

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() 
            { 10, 20, 30, 40, 50, 60, 70, 80};

            var customList = list.Where(x => x > 40).ToList();

            foreach ( var custom in customList )
            {
                Console.WriteLine(custom);
            }
        }
    }
}