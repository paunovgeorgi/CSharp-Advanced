int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int n = input[0];
int m = input[1];
HashSet<int> firstSet = new HashSet<int>();
HashSet<int> secondSet = new HashSet<int>();

for (int i = 0; i < n; i++)
{
    firstSet.Add(int.Parse(Console.ReadLine()));
}
for (int i = 0; i < m; i++)
{
    secondSet.Add(int.Parse(Console.ReadLine()));
}

var commonElements = firstSet.Intersect(secondSet);

foreach (var i in commonElements)
{
    Console.Write(i + " ");
}
