using System.ComponentModel.DataAnnotations;

Dictionary<string, string> contests = new Dictionary<string, string>();

Dictionary<string, Dictionary<string, double>> userData = new Dictionary<string, Dictionary<string, double>>();

string initialInfo;

while ((initialInfo = Console.ReadLine()) != "end of contests")
{
    string[] tokens = initialInfo.Split(":");

    string contest = tokens[0];
    string password = tokens[1];

    if (!contests.ContainsKey(contest))
    {
        contests.Add(contest, password);
    }
}


string secondaryInfo;

while ((secondaryInfo = Console.ReadLine()) != "end of submissions")
{
    string[] tokens = secondaryInfo.Split("=>", StringSplitOptions.RemoveEmptyEntries);

    string contest = tokens[0];
    string password = tokens[1];
    string username = tokens[2];
    double score = double.Parse(tokens[3]);

    if (contests.ContainsKey(contest) && contests[contest] == password)
    {
        if (!userData.ContainsKey(username)) 
        {
        userData.Add(username, new Dictionary<string, double>());
        userData[username].Add(contest, score);
        }
        else
        {
            if (userData[username].ContainsKey(contest))
            {
                if (score > userData[username][contest])
                {
                userData[username][contest] = score;
                }
            }
            else
            {
                userData[username].Add(contest, score);
            }
        }
    }
}


double maxPoints = 0;
string maxUser = String.Empty;

foreach (KeyValuePair<string, Dictionary<string, double>> username in userData)
{
    double sum = 0;
    sum += username.Value.Sum(x=>x.Value);
    if (sum > maxPoints)
    {
        maxPoints = sum;
        maxUser = username.Key;
    }
}

Console.WriteLine($"Best candidate is {maxUser} with total {maxPoints} points.");
Console.WriteLine("Ranking: ");

foreach (KeyValuePair<string, Dictionary<string, double>> user in userData.OrderBy(x=>x.Key))
{
    Console.WriteLine(user.Key);
    foreach (KeyValuePair<string, double> data in user.Value.OrderByDescending(x=>x.Value))
    {
        Console.WriteLine($"#  {data.Key} -> {data.Value}");
    }
}