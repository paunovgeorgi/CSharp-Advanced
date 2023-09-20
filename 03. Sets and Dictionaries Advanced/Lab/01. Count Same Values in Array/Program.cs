double[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

Dictionary<double, int> summery = new Dictionary<double, int>();

foreach (double num in input)
{
    if (!summery.ContainsKey(num))
    {
        summery.Add(num, 1);
    }
    else
    {
        summery[num]++;
    }
}

foreach (var pair in summery)
{
    Console.WriteLine($"{pair.Key} - {pair.Value} times");
}