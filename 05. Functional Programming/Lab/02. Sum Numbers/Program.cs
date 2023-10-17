int[] numbers = Console.ReadLine().Split(", ").Select(x => int.Parse(x)).ToArray();

Console.WriteLine(numbers.Length);
Console.WriteLine(numbers.Sum());