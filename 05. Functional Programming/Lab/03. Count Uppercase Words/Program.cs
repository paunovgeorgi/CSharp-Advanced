Predicate<string> isUpper = word => char.IsUpper(word[0]);

string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(word => isUpper(word)).ToArray();

Console.WriteLine(string.Join(" ", input));