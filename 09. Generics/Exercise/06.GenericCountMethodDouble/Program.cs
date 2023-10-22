namespace _06.GenericCountMethodDouble
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Box<double> items = new();
            for (int i = 0; i < num; i++)
            {
                double input = double.Parse(Console.ReadLine());
                items.Add(input);
            }

            double toCompare = double.Parse(Console.ReadLine());

            Console.WriteLine(items.Count(toCompare));
        }
    }
}