Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] tokens = Console.ReadLine().Split(" -> ");
    string color = tokens[0];
    string[] items = tokens[1].Split(",");

    if (!clothes.ContainsKey(color))
    {
        clothes.Add(color, new Dictionary<string, int>());
    }

    foreach (var item in items)
    {
        if (!clothes[color].ContainsKey(item))
        {
            clothes[color].Add(item, 1);
        }
        else
        {
            clothes[color][item]++;
        }
    }
}

string[] request = Console.ReadLine().Split();
string colorToFind = request[0];
string itemToFind = request[1];
bool isFound = false;

foreach (KeyValuePair<string, Dictionary<string, int>> clothe in clothes)
{
    if (clothe.Key == colorToFind)
    {
        isFound = true;
    }
    Console.WriteLine($"{clothe.Key} clothes:");
    foreach (KeyValuePair<string, int> item in clothe.Value)
    {
        if (isFound && item.Key == itemToFind)
        {
            Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
        }
        else
        {
            Console.WriteLine($"* {item.Key} - {item.Value}");
        }
    }
    isFound = false;
}