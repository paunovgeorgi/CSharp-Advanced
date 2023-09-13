int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
Queue<int> queueOfNums = new Queue<int>(numbers);
List<int> evenNums = new List<int>();
while (queueOfNums.Count > 0)
{
    int currentNum = queueOfNums.Dequeue();
    
    if (currentNum % 2 == 0)
    {
        evenNums.Add(currentNum);
    }
}
Console.WriteLine(string.Join(", ", evenNums));