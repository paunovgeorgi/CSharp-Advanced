string input = Console.ReadLine();

Dictionary<char, int> symbols = new Dictionary<char, int>();

foreach (char c in input)
{
    if (!symbols.ContainsKey(c))
    {
        symbols.Add(c, 1);
    }
    else
    {
        symbols[c]++;
    }
}

foreach (var symbol in symbols.OrderBy(x=>x.Key))
{
    Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
}