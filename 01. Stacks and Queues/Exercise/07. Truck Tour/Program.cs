int numOfPumps = int.Parse(Console.ReadLine());
Queue<int[]> pumps = new();
for (int i = 0; i < numOfPumps; i++)
{
    int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
    pumps.Enqueue(tokens);
}
int startIndex = 0;

while (true)
{
    bool isComplete = true;
    int totalFuel = 0;

    foreach (var pump in pumps)
    {
        int fuel = pump[0];
        int distance = pump[1];

        totalFuel += fuel;

        if (totalFuel - distance < 0)
        {
            startIndex++;

            int[] currentPump = pumps.Dequeue();
            pumps.Enqueue(currentPump);
            isComplete = false;
            break;
        }
        totalFuel -= distance;
    }
    if (isComplete)
    {
        Console.WriteLine(startIndex);
        break;
    }
}