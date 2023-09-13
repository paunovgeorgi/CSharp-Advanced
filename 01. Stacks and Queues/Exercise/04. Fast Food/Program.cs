using System.Runtime.CompilerServices;
int foodQuantity = int.Parse(Console.ReadLine());
int[] totalOrders = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
Queue<int> orders = new Queue<int>(totalOrders); 
Console.WriteLine(orders.Max());
while (orders.Count > 0)
{
    if (foodQuantity >= orders.Peek())
    {
        foodQuantity -= orders.Dequeue();
    }
    else
    {
        Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
        return;
    }
}
Console.WriteLine("Orders complete");