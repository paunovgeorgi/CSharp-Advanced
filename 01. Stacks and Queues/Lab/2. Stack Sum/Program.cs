int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
Stack<int> stackOfNums = new Stack<int>(numbers);
string input = string.Empty;
while ((input = Console.ReadLine().ToLower()) != "end")
{
    string[] arguments = input.Split();
    string command = arguments[0];
    switch (command)
    {
        case "add":
            int num1 = int.Parse(arguments[1]);
            int num2 = int.Parse(arguments[2]);
            stackOfNums.Push(num1);
            stackOfNums.Push(num2);
            break;
        case "remove":
            int elementsToRemove = int.Parse(arguments[1]);
            if (stackOfNums.Count >= elementsToRemove)
            {
                for (int i = 0; i < elementsToRemove; i++)
                {
                    stackOfNums.Pop();
                }
            }
            break;
    }
}
Console.WriteLine($"Sum: {stackOfNums.Sum()}");