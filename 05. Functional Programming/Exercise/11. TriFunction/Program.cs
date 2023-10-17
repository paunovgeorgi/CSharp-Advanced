int num = int.Parse(Console.ReadLine());
string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

Func<string, int, bool> traverse = (name, num) =>
{
    int sum = name.Sum(x => x);
    return sum >= num;
};

Func<Func<string, int, bool>, string[], int, string> output = (func, array, num) =>
{
    foreach (string name in array)
    {
        if (func(name, num))
        {
            return name;
        }

    }

    return null;
};

Console.WriteLine(output(traverse, names, num));