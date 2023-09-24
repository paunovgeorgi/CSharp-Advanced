Dictionary<string, int> submissionsCount = new Dictionary<string, int>();
Dictionary<string, Dictionary<string, int>> submissions = new Dictionary<string, Dictionary<string, int>>();

string input;
int points = 0;
while ((input = Console.ReadLine()) != "exam finished")
{
    string[] tokens = input.Split("-", StringSplitOptions.RemoveEmptyEntries);

    string username = tokens[0];
    string language = tokens[1];
    if (tokens.Length > 2)
    {
    points = int.Parse(tokens[2]);
    }
    if (language == "banned")
    {
        if (submissions.ContainsKey(username))
        {
            submissions.Remove(username);
        }
    }
    else
    {
        if (!submissions.ContainsKey(username))
    {
        submissions.Add(username, new Dictionary<string, int>());
        if (!submissions[username].ContainsKey(language))
        {
            submissions[username].Add(language, points);
        }
    }
        else
        {
            if (!submissions[username].ContainsKey(language))
            {
                submissions[username].Add(language, points);
            }
            if (points > submissions[username][language])
            {
                submissions[username][language] = points;
            }
        }

        if (!submissionsCount.ContainsKey(language))
    {
        submissionsCount.Add(language, 1);
    }
    else
    {
        submissionsCount[language]++;
    }
    }
    
}

Console.WriteLine("Results: ");
foreach (KeyValuePair<string, Dictionary<string, int>> user in submissions.OrderByDescending(x=>x.Value.Values.Sum()).ThenBy(x=>x.Key))
{

    Console.WriteLine($"{user.Key} | {user.Value.Values.Max()}");
}
Console.WriteLine("Submissions: ");
foreach (var submission in submissionsCount.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
{
    Console.WriteLine($"{submission.Key} - {submission.Value}");
}