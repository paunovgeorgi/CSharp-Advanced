﻿//List<int> numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Where(x=>x % 2 == 0).OrderBy(x=>x).ToList();
//Console.WriteLine(string.Join(", ", numbers));

Console.WriteLine(string.Join(", ", (Console.ReadLine().Split(", ").Select(int.Parse).Where(x=>x % 2 == 0).OrderBy(x=>x))));
