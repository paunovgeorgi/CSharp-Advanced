using System.Xml;


int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

string filter = Console.ReadLine();

Func<int[], string, string> FindOddOrEven = OddOrEven;

Console.WriteLine(FindOddOrEven(input, filter));

string OddOrEven(int[] numbers, string command)
{
    List<int> output = new();

    int start = numbers[0];
    int end = numbers[1];

    if (command == "odd")
    {
        for (int i = start; i <= end; i++)
        {
            if (i % 2 != 0)
            {
                output.Add(i);
            }
        }
    }
    else
    {
        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
            {
                output.Add(i);
            }
        }
    }
    return $"{string.Join(" ", output)}";
}

