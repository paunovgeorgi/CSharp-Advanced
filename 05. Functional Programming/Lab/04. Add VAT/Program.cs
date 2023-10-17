//double[] vat = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).Select(num => num * 1.20).ToArray();

//foreach (double num in vat)
//{
//    Console.WriteLine($"{num:f2}");
//}

Console.WriteLine(string.Join("\n", Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse)
    .Select(x => (x *= 1.2).ToString("f2")).ToList()));