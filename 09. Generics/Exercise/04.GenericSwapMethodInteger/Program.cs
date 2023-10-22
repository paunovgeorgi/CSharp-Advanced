namespace _04.GenericSwapMethodInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int input = int.Parse(Console.ReadLine());
                numbers.Add(input);
            }

            int[] swapCommands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            Swap<int>(swapCommands[0], swapCommands[1], numbers);

            foreach (int num in numbers)
            {
                Console.WriteLine($"{typeof(int)}: {num}");
            }
        }

        static void Swap<T>(int indexOne, int indexTwo, List<T> list)
        {
            (list[indexOne], list[indexTwo]) = (list[indexTwo], list[indexOne]);
        }
    }
    
}