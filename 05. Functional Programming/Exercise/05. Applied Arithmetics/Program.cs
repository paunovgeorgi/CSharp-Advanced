int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

Action<int[]> print = array =>
{
    Console.WriteLine(string.Join(" ", array));
};

Func<int[], string, int[]> execute = (numbers, command) =>
{
    switch (command)
    {
        case "add":
            numbers = Add(numbers);
            break;
        case "multiply":
            numbers = Multiply(numbers);
            break;
        case "subtract":
            numbers = Subtract(numbers);
            break;
    }

    return numbers;
};

string command = string.Empty;

while ((command = Console.ReadLine()) != "end")
{
    if (command == "print")
    {
        print(numbers);
    }
    else
    {
        execute(numbers, command);
    }
}

int[] Add(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] += 1;
    }

    return array;
}

int[] Multiply(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= 2;
    }

    return array;
}

int[] Subtract(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] -= 1;
    }
    return array;
}