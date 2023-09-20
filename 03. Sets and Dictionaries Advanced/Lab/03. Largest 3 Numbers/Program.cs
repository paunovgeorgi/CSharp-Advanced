using System.Globalization;
List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
numbers = numbers.OrderByDescending(x=>x).ToList();
int count = 0;

    foreach (var number in numbers)
    {
        Console.Write($"{number} ");
        count++;
        if (count == 3)
        {
            break;
        }
    }