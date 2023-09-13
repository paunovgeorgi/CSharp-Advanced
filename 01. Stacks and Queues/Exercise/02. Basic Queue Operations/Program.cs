int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
Queue<int> numbers = new Queue<int>();
int elementsToPush = input[0];
int elementsToPop = input[1];
int elementToLookFor = input[2];
int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
for (int i = 0; i < elements.Length; i++)
{
    if (numbers.Count < elementsToPush)
    {
        numbers.Enqueue(elements[i]);
    }
}
for (int i = 0; i < elementsToPop; i++)
{
    numbers.Dequeue();
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