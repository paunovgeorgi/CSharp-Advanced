using System.Security.Cryptography.X509Certificates;

int[] inputNums = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToArray();

Func<int[], int> altSmallest = array => array.Min();
Console.WriteLine(altSmallest(inputNums));
