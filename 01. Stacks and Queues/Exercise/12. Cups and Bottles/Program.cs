Queue<int> cups = new(Console.ReadLine().Split().Select(int.Parse).ToArray());
Stack<int> bottles = new(Console.ReadLine().Split().Select(int.Parse).ToArray());
int currentBottle = 0;
int currentCup = 0;
int wastedWater = 0;

while (cups.Any() && bottles.Any())
{
    currentCup = cups.Peek();
    while (currentCup > 0)
    {  
    currentBottle = bottles.Pop();
    if (currentBottle > currentCup)
    {
            wastedWater += currentBottle - currentCup;
        cups.Dequeue();
        currentCup = 0;
    }
    else if (currentBottle == currentCup)
    {
            cups.Dequeue();
            currentCup = 0;
    }
    else
    {
            currentCup -= currentBottle;
    }
    }
}

if (bottles.Any())
{
    Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
}
else
{
    Console.WriteLine($"Cups: {string.Join(" ", cups)}");
}

Console.WriteLine($"Wasted litters of water: {wastedWater}");