Dictionary<string, List<string>> theForce = new Dictionary<string, List<string>>();
HashSet<string> users = new HashSet<string>();
string input;

while ((input = Console.ReadLine()) != "Lumpawaroo")
{
    if (input.Contains("|"))
    {
        string[] tokens = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToArray();
        string side = tokens[0];
        string name = tokens[1];
        if (!theForce.ContainsKey(side))
        {
            theForce.Add(side, new List<string>());
        }

        if (!theForce[side].Contains(name) && !users.Contains(name))
        {
            theForce[side].Add(name);
        }

        if (!users.Contains(name))
        {
            users.Add(name);
        }
    }
    else if (input.Contains("->"))
    {
        string[] tokens = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
        string name = tokens[0];
        string side = tokens[1];
        if (users.Contains(name))
        {
            string sideName = string.Empty;
            foreach (KeyValuePair<string, List<string>> pair in theForce)
            {
                if (pair.Value.Contains(name))
                {
                    sideName = pair.Key;
                }
            }
            theForce[sideName].Remove(name);
            if (!theForce.ContainsKey(side))
            {
                theForce.Add(side, new List<string>());
            }
            theForce[side].Add(name);
            Console.WriteLine($"{name} joins the {side} side!");
        }
        else
        {
            if (!theForce.ContainsKey(side))
            {
                theForce.Add(side, new List<string>());
            }
            theForce[side].Add(name);
            users.Add(name);
            Console.WriteLine($"{name} joins the {side} side!");
        }
    }
}

foreach (KeyValuePair<string, List<string>> pair in theForce.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
{
    if (pair.Value.Count > 0)
    {
        Console.WriteLine($"Side: {pair.Key}, Members: {pair.Value.Count}");
        foreach (string user in pair.Value.OrderBy(x => x))
        {
            Console.WriteLine($"! {user}"); 
        }
    }
}