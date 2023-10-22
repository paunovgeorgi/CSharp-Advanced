using System.Security.Cryptography.X509Certificates;

namespace _05.GenericCountMethodString
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Box<string> items = new();
            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();
                items.Add(input);
            }

            string toCompare = Console.ReadLine();
            
            Console.WriteLine(items.Count(toCompare));

        }
    }
}