string[] kids = Console.ReadLine().Split();
int num = int.Parse(Console.ReadLine());
Queue<string> potato = new(kids);

while (potato.Count > 1)
{
    for (int i = 1; i < num; i++)
    {
        string currentKid = potato.Dequeue();
        potato.Enqueue(currentKid);
    }
    Console.WriteLine($"Removed {potato.Dequeue()}");
}

Console.WriteLine($"Last is {potato.Peek()}");