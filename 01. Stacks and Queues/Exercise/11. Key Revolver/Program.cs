int bulletPrice = int.Parse(Console.ReadLine());
int barrelSize = int.Parse(Console.ReadLine());
int barrelConstant = barrelSize;
int[] initialBullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] initialLocks = Console.ReadLine().Split().Select(int.Parse).ToArray();
int intelligence = int.Parse(Console.ReadLine());
Queue<int> locks = new Queue<int>(initialLocks);
Stack<int> bullets = new(initialBullets);
while (locks.Any() && bullets.Any())
{
    if (bullets.Pop() <= locks.Peek())
    {
        Console.WriteLine("Bang!");
        locks.Dequeue();
    }
    else
    {
        Console.WriteLine("Ping!");
    }
        barrelSize--;

    if (barrelSize == 0)
    {
        if (bullets.Any())
        {
            barrelSize = barrelConstant;
            Console.WriteLine("Reloading!");
        }
    }
}

if (!bullets.Any() && locks.Any())
{
    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
}
else
{
    int bulletsShot = initialBullets.Length - bullets.Count;
    int totalBulletPrice = bulletsShot * bulletPrice;
    Console.WriteLine($"{bullets.Count} bullets left. Earned ${intelligence - totalBulletPrice}");
}