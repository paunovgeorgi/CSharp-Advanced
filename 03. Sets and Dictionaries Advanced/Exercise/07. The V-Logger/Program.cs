using System.Dynamic;
Dictionary<string, Statistics> vlogers = new Dictionary<string, Statistics>();
string input;

while ((input = Console.ReadLine()) != "Statistics")
{
    string[] tokens = input.Split();
    string vloger1 = tokens[0];
    string action = tokens[1];

    switch (action)
    {
        case "joined":
            if (!vlogers.ContainsKey(vloger1))
            {
                vlogers.Add(vloger1, new Statistics());
            }
            break;
        case "followed":
            string vloger2 = tokens[2];
            if (vloger1 != vloger2)
            {
                if (vlogers.ContainsKey(vloger1) && vlogers.ContainsKey(vloger2))
                {
                    if (!vlogers[vloger1].Following.Contains(vloger2))
                    {
                        vlogers[vloger1].Following.Add(vloger2);
                        vlogers[vloger2].Followers.Add(vloger1);
                    }
                }
            }

            break;
    }
}

Console.WriteLine($"The V-Logger has a total of {vlogers.Count} vloggers in its logs.");

string vlogerToRemove = string.Empty;

foreach (KeyValuePair<string, Statistics> vloger in vlogers.OrderByDescending(x=>x.Value.Followers.Count).ThenBy(x=>x.Value.Following.Count))
{
    Console.WriteLine($"1. {vloger.Key} : {vloger.Value.Followers.Count} followers, {vloger.Value.Following.Count} following");
    vlogerToRemove = vloger.Key;
    if (vloger.Value.Followers.Count > 0)
    {
    foreach (var follower in vloger.Value.Followers.OrderBy(x=>x))
    {
        Console.WriteLine($"*  {follower}");
    }
    }
    break;
}

vlogers.Remove(vlogerToRemove);
int counter = 2;
foreach (var vloger in vlogers.OrderByDescending(x=>x.Value.Followers.Count).ThenBy(x=>x.Value.Following.Count))
{
    Console.WriteLine($"{counter}. {vloger.Key} : {vloger.Value.Followers.Count} followers, {vloger.Value.Following.Count} following");
    counter++;
}

public class Statistics
{
    public Statistics()
    {
        Followers = new List<string>();
        Following = new List<string>();
    }

    public List<string> Followers { get; set; }
    public List<string> Following { get; set; }

}