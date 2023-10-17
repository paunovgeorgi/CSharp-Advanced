int range = int.Parse(Console.ReadLine());

List<int> dividers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

List<Predicate<int>> predicates = new();

foreach (int divider in dividers)
{
    predicates.Add(n=>n % divider == 0);
}

for (int i = 1; i <= range; i++)
{
    bool isDivisible = true;

    foreach (Predicate<int> predicate in predicates)
    {
        if (!predicate(i))
        {
            isDivisible = false;
        }
    }

    if (isDivisible)
    {
        Console.Write(i + " ");
    }
}