Action<string[]> printer = array => Console.WriteLine(string.Join("\n", array));

string[] namesInput = Console.ReadLine().Split();

printer(namesInput);