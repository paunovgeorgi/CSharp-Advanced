using System.Runtime.InteropServices;

int[] input = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Func<int[], List<int>> reverse = array =>
{
    List<int> reversed = new List<int>();

    for (int i = array.Length - 1; i >= 0; i--)
    {
        reversed.Add(array[i]);
    }
    return reversed;
};

List<int> outputList = reverse(input);
int divider = int.Parse(Console.ReadLine());
Func<List<int>, Predicate<int>, List<int>> excluded = (list, match) =>
{
    List<int> result = new List<int>();
     
    foreach (var number in list)
    {
        if (match(number))
        {
            result.Add(number);
        }
    }

    return result;
};

outputList = excluded(outputList, num => num % divider != 0);

Console.WriteLine(string.Join(" ", outputList));