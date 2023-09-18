int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
Stack<int> numbers = new Stack<int>();
int elementsToPush = input[0];
int elementsToPop = input[1];
int elementToLookFor = input[2];
for (int i = 0; i < elements.Length; i++)
{
    if(numbers.Count < elementsToPush)
    {
        numbers.Push(elements[i]);
    }
}
for (int i = 0; i < elementsToPop; i++)
{
    numbers.Pop();
}

if (numbers.Count == 0)
{
    Console.WriteLine(0);
}
else if (numbers.Contains(elementToLookFor))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine(numbers.Min());
}

