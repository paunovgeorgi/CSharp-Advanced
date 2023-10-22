namespace _08.Threeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] namdAddTown = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] drunkOrNot = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] bankBalance = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Threeuple<string, string, string> name = new($"{namdAddTown[0]} {namdAddTown[1]}", namdAddTown[2], string.Join(" ", namdAddTown[3..]));

            Threeuple<string, int, bool> beer = new(drunkOrNot[0], int.Parse(drunkOrNot[1]), (drunkOrNot[2] == "drunk"));

            Threeuple<string, double, string> numbers = new(bankBalance[0], double.Parse(bankBalance[1]), bankBalance[2]);


            Console.WriteLine(name.ToString());
            Console.WriteLine(beer.ToString());
            Console.WriteLine(numbers.ToString());
        }
    }
}