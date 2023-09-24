int n = int.Parse(Console.ReadLine());
List<int> numbers = new List<int>();
Dictionary<int, int> findEven = new Dictionary<int, int>();
for (int i = 0; i < n; i++)
{
    numbers.Add(int.Parse(Console.ReadLine()));
}

foreach (int number in numbers)
{
    if (!findEven.ContainsKey(number))
    {
        findEven.Add(number, 1);
    }
    else
    {
        findEven[number]++;
    }
}

int evenNum = findEven.Single(x => x.Value % 2 == 0).Key;
Console.WriteLine(evenNum);

//foreach (var num in findEven)
//{
//    if (num.Value % 2 == 0)
//    {
//        Console.WriteLine(num.Key);
//        break;
//    }
//}