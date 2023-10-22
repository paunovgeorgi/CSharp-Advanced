namespace _01.GenericBoxofString
{
    public class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string item = Console.ReadLine();
                Box<string> box = new(item);
                Console.WriteLine(box.ToString());
            }
        }
    }
}