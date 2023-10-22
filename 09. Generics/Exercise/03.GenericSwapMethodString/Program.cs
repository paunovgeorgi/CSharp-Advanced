namespace _03.GenericSwapMethodString
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                list.Add(input);
            }

            int[] swapCommands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            Swap<string>(swapCommands[0], swapCommands[1], list);

            foreach (string s in list)
            {
                Console.WriteLine($"{typeof(string)}: {s}");
            }
        }

        static void Swap<T>(int indexOne, int indexTwo, List<T> list)
        {
            (list[indexOne], list[indexTwo]) = (list[indexTwo], list[indexOne]);
        }
    }
}