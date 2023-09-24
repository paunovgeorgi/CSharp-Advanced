int n = int.Parse(Console.ReadLine());
SortedSet<string> elements = new SortedSet<string>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    elements.UnionWith(input);

    //foreach (string element in input)
    //{
    //    elements.Add(element);
    //}
}

Console.WriteLine(string.Join(" ",  elements));