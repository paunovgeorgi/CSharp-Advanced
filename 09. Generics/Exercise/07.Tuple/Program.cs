namespace _07.Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] namdAndAddress = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] beerDrinkingCapabilities = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] intAndDouble = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            CustomTuple<string, string> name = new($"{namdAndAddress[0]} {namdAndAddress[1]}", namdAndAddress[2]);

            CustomTuple<string, int> beer = new(beerDrinkingCapabilities[0], int.Parse(beerDrinkingCapabilities[1]));

            CustomTuple<int, double> numbers = new(int.Parse(intAndDouble[0]), double.Parse(intAndDouble[1]));


            Console.WriteLine(name.ToString());
            Console.WriteLine(beer.ToString());
            Console.WriteLine(numbers.ToString());

        }
    }
}