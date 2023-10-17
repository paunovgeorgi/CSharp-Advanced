
int length = int.Parse(Console.ReadLine());
Console.WriteLine(string.Join(Environment.NewLine, Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Where(x => x.Length <= length).ToArray()));

//List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

//Action<List<string>, Predicate<string>> print = (names, match) =>
//{
//    foreach (string name in names)
//    {
//        if (match(name))
//        {
//            Console.WriteLine(name);
//        }
//    }
//};

//print(names, name => name.Length <= length);


