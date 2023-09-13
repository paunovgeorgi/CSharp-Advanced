int n = int.Parse(Console.ReadLine());
Stack<int> numbers = new Stack<int>();
for (int i = 0; i < n; i++)
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int command = input[0];
    switch (command)
    {
        case (1):
            int element = input[1];
            numbers.Push(element);
            break;
        case (2):
            numbers.Pop();
            break;
        case (3):
            if (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Max());
            }
            break;
        case (4):
            if (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Min());
            }
            break;
    }
}
Console.WriteLine(string.Join(", ", numbers));