string input = Console.ReadLine();
Stack<string> reversedInput = new Stack<string>();
foreach (char c in input)
{
    reversedInput.Push(c.ToString());
}
Console.WriteLine(string.Join("", reversedInput));