//int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
//int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
//Stack<int> numbers = new Stack<int>();
//int elementsToPush = input[0];
//int elementsToPop = input[1];
//int elementToLookFor = input[2];
//for (int i = 0; i < elements.Length; i++)
//{
//    if(numbers.Count < elementsToPush)
//    {
//        numbers.Push(elements[i]);
//    }
//}
//for (int i = 0; i < elementsToPop; i++)
//{
//    numbers.Pop();
//}

//if (numbers.Count == 0)
//{
//    Console.WriteLine(0);
//}
//else if (numbers.Contains(elementToLookFor))
//{
//    Console.WriteLine("true");
//}
//else
//{
//    Console.WriteLine(numbers.Min());
//}

int[] liliesInput = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int[] rosesInput = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

Stack<int> lilies = new Stack<int>(liliesInput);
Queue<int> roses = new Queue<int>(rosesInput);
int storedSum = 0;
int wreahts = 0;

while (lilies.Any() && roses.Any())
{
    int currentLilies = lilies.Peek();
    int currentRoses = roses.Peek();

    if (currentLilies + currentRoses == 15)
    {
        wreahts++;
        lilies.Pop();
        roses.Dequeue();
    }
    else if (currentLilies + currentRoses > 15)
    {
        currentLilies -= 2;
        lilies.Pop();
        lilies.Push(currentLilies);
    }
    else
    {
        storedSum += lilies.Pop() + roses.Dequeue();
    }
}

if (storedSum >= 15)
{
int additionalWreaths = storedSum / 15;
wreahts += additionalWreaths;
}

if (wreahts >= 5)
{
    Console.WriteLine($"You made it, you are going to the competition with {wreahts} wreaths!");
}
else
{
    Console.WriteLine($"You didn't make it, you need {5 - wreahts} wreaths more!");
}