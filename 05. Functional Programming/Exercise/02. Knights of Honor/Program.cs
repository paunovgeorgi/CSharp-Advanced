string[] namesInput = Console.ReadLine().Split();

Action<string[]> print = array =>
{
    foreach (var name in array)
    {
        Console.WriteLine($"Sir {name}");
    }
};

print(namesInput);