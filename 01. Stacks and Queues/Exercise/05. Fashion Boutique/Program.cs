int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rackCapacity = int.Parse(Console.ReadLine());
Stack<int> box = new Stack<int>(clothes);
int racks = 1;
int clothesInRack = 0;

while (box.Count > 0)
{
    if (clothesInRack + box.Peek() <= rackCapacity)
    {
        clothesInRack += box.Pop();
    }

    else
    {
        clothesInRack = 0;
        racks++;
    }
}

Console.WriteLine(racks);